using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovator.Client.QueryModel
{
  public class SqlServerVisitor : IQueryVisitor
  {
    private TextWriter _writer;
    private IAmlSqlWriterSettings _settings;
    private Stack<IOperator> _operators = new Stack<IOperator>();
    private IServerContext _context = ElementFactory.Utc.LocalizationContext;
    private bool _hasFromOrSelect = false;
    private AmlSqlRenderOption _renderOption;

    public SqlServerVisitor(TextWriter writer, IAmlSqlWriterSettings settings)
    {
      _writer = writer;
      _settings = settings;
      _renderOption = _settings.RenderOption;
    }

    public SqlServerVisitor(TextWriter writer, IAmlSqlWriterSettings settings, IServerContext context)
      : this(writer, settings)
    {
      _context = context;
    }

    public void Visit(QueryItem query)
    {
      if (_renderOption == AmlSqlRenderOption.Default)
      {
        if (query.Attributes.TryGetValue("offsetId", out var offsetId))
        {
          _renderOption = AmlSqlRenderOption.OffsetQuery;
        }
        else if (query.Attributes.TryGetValue("returnMode", out var returnMode)
          && string.Equals(returnMode, "countOnly", StringComparison.Ordinal))
        {
          _renderOption = AmlSqlRenderOption.CountQuery;
        }
        else
        {
          _renderOption = AmlSqlRenderOption.SelectQuery;
        }
      }

      switch (_renderOption)
      {
        case AmlSqlRenderOption.CountQuery:
          _writer.Write("select isnull(sum(cnt), 0) count from (select ");
          WritePermissionFields(query);
          _writer.Write(", count(*) cnt ");
          VisitFrom(query);
          VisitWhere(query);
          _writer.Write(" group by ");
          WritePermissionFields(query);
          _writer.Write(") perm where ");
          WritePermissionCheck(() => _writer.Write("perm"));
          break;
        case AmlSqlRenderOption.OffsetQuery:
          _writer.Write("select isnull(sum(cnt), 0) offset from ( select ");
          WritePermissionFields(query);
          _writer.Write(", count(*) cnt from ");
          VisitTableName(query);
          _writer.Write(" inner join ( select ");
          var first = true;
          foreach (var orderBy in GetOrderBy(query))
          {
            if (!first)
              _writer.Write(", ");
            first = false;
            orderBy.Expression.Visit(this);
          }
          _writer.Write(" ");
          VisitFrom(query);
          VisitWhere(query);
          _writer.Write(") offset on ");

          var cols = GetOrderBy(query).ToArray();
          for (var i = 0; i < cols.Length; i++)
          {
            if (i > 0)
              _writer.Write(" or ");
            _writer.Write('(');
            for (var j = 0; j < i; j++)
            {
              WriteAlias(query);
              _writer.Append(".[");
              _writer.Write(((PropertyReference)cols[j].Expression).Name);
              _writer.Write("] = offset.[");
              _writer.Write(((PropertyReference)cols[j].Expression).Name);
              _writer.Write("] and ");
            }
            WriteAlias(query);
            _writer.Append(".[");
            _writer.Write(((PropertyReference)cols[i].Expression).Name);
            _writer.Write(cols[i].Ascending ? "] < " : "] > ");
            _writer.Write("offset.[");
            _writer.Write(((PropertyReference)cols[i].Expression).Name);
            _writer.Write("])");
          }

          var genVisitor = new GenerationCriteriaVisitor();
          query.Where.Visit(genVisitor);
          if (genVisitor.Criteria != null)
          {
            _writer.Write(" where ");
            genVisitor.Criteria.Visit(this);
          }

          _writer.Write(" group by ");
          WritePermissionFields(query);
          _writer.Write(" ) perm where ");
          WritePermissionCheck(() => _writer.Write("perm"));
          break;
        default:
          if ((_renderOption & AmlSqlRenderOption.SelectClause) != 0)
            VisitSelect(query);
          if ((_renderOption & AmlSqlRenderOption.FromClause) != 0)
            VisitFrom(query);
          if ((_renderOption & AmlSqlRenderOption.WhereClause) != 0)
            VisitWhere(query);
          if ((_renderOption & AmlSqlRenderOption.OrderByClause) != 0)
            VisitOrderBy(query);

          if ((_renderOption & AmlSqlRenderOption.OffsetClause) != 0)
          {
            if (query.Fetch > 0 && query.Offset > 0)
            {
              _writer.Write(" offset ");
              _writer.Write(query.Offset);
              _writer.Write(" rows fetch next ");
              _writer.Write(query.Fetch);
              _writer.Write(" rows only");
            }
          }
          break;
      }
    }

    private class GenerationCriteriaVisitor : SimpleVisitor
    {
      public IExpression Criteria { get; set; }

      public override void Visit(EqualsOperator op)
      {
        if (op.Left is PropertyReference prop
          && op.Right is BooleanLiteral boolLit
          && (prop.Name == "is_current" || prop.Name == "is_active_rev"))
        {
          Criteria = op;
        }
      }
    }

    private void WritePermissionFields(QueryItem query)
    {
      WriteAlias(query);
      _writer.Write(".permission_id, ");
      WriteAlias(query);
      _writer.Write(".created_by_id, ");
      WriteAlias(query);
      _writer.Write(".managed_by_id, ");
      WriteAlias(query);
      _writer.Write(".owned_by_id, ");
      WriteAlias(query);
      _writer.Write(".team_id");
    }

    private void VisitSelect(QueryItem query)
    {
      _hasFromOrSelect = true;
      _writer.Write("select ");

      if ((_renderOption & AmlSqlRenderOption.OffsetClause) != 0
        && query.Fetch > 0
        && (query.Offset ?? 0) < 1)
      {
        _writer.Write("top ");
        _writer.Write(query.Fetch);
        _writer.Write(' ');
      }

      if (!query.Select.Any())
      {
        WriteAlias(query);
        _writer.Write(".*");
      }
      else
      {
        var first = true;
        foreach (var prop in query.Select)
        {
          if (!first)
            _writer.Write(", ");
          first = false;
          prop.Expression.Visit(this);
          if (!string.IsNullOrEmpty(prop.Alias))
          {
            _writer.Write(" as [");
            _writer.Write(prop.Alias);
            _writer.Write("]");
          }
        }
      }
    }

    private void TryFillName(QueryItem item)
    {
      if (string.IsNullOrEmpty(item.Type) && !string.IsNullOrEmpty(item.TypeProvider?.Table.Type))
      {
        var props = _settings.GetProperties(item.TypeProvider.Table.Type);
        if (props != null && props.TryGetValue(item.TypeProvider.Name, out var propDefn))
        {
          item.Type = propDefn.DataSource().KeyedName().Value;
        }
      }
    }

    private void WriteAlias(QueryItem item)
    {
      TryFillName(item);

      _writer.Write('[');
      if (!string.IsNullOrEmpty(item.Alias))
        _writer.Write(item.Alias);
      else
        _writer.Write(item.Type.Replace(' ', '_'));
      _writer.Write(']');
    }

    private void VisitFrom(QueryItem item)
    {
      if (_hasFromOrSelect)
        _writer.Write(" ");
      _hasFromOrSelect = true;
      _writer.Write("from ");
      VisitTableName(item);
      foreach (var join in item.Joins.Where(j => j.GetCardinality() == Cardinality.OneToOne))
      {
        VisitJoin(join);
      }
    }

    private void VisitTableName(QueryItem item)
    {
      var secured = _settings.PermissionOption == AmlSqlPermissionOption.SecuredFunction
        || _settings.PermissionOption == AmlSqlPermissionOption.SecuredFunctionEnviron;
      if (_renderOption == AmlSqlRenderOption.CountQuery
        || _renderOption == AmlSqlRenderOption.OffsetQuery)
      {
        secured = false;
      }

      _writer.Write(secured ? "[secured].[" : "[innovator].[");
      var sqlName = item.Type.Replace(' ', '_');
      _writer.Write(sqlName);
      _writer.Write("]");

      if (secured)
      {
        _writer.Append("('can_get','")
          .Append(_settings.IdentityList)
          .Append("',null,'")
          .Append(_settings.UserId)
          .Append("',null");
        if (_settings.PermissionOption == AmlSqlPermissionOption.SecuredFunctionEnviron)
          _writer.Append(",null");
        _writer.Append(")");
      }

      if (!string.IsNullOrEmpty(item.Alias) && !string.Equals(item.Alias, sqlName, StringComparison.OrdinalIgnoreCase))
      {
        _writer.Write(" as [");
        _writer.Write(item.Alias);
        _writer.Write("]");
      }
    }

    private void VisitJoin(Join join)
    {
      if (join.Type == JoinType.Inner)
        _writer.Write(" inner join ");
      else
        _writer.Write(" left join ");

      VisitTableName(join.Right);
      _writer.Write(" on ");
      join.Condition.Visit(this);

      foreach (var otherJoin in join.Right.Joins.Where(j => j.GetCardinality() == Cardinality.OneToOne))
      {
        VisitJoin(otherJoin);
      }
    }

    private void VisitWhere(QueryItem query)
    {
      var criteria = new List<IExpression>();
      var clause = AddPermissionCheck(query);

      if (_settings.RenderOption == AmlSqlRenderOption.OffsetQuery)
      {
        if (!query.Attributes.TryGetValue("offsetId", out var offsetId))
          throw new InvalidOperationException("No `offsetId` attribute was specified");

        clause = AppendCriteria(clause, new EqualsOperator()
        {
          Left = new PropertyReference("id", query),
          Right = new StringLiteral(offsetId)
        });
      }

      if (clause != null)
        criteria.Add(clause);
      AddJoinsToCriteria(query, criteria);

      if (criteria.Count > 0)
      {
        var expr = criteria[0];
        foreach (var otherExpr in criteria.Skip(1))
        {
          expr = new AndOperator()
          {
            Left = expr,
            Right = otherExpr
          };
        }

        if (_hasFromOrSelect)
          _writer.Write(" where ");
        expr.Visit(this);
      }
    }

    private IExpression AddPermissionCheck(QueryItem query)
    {
      var clause = query.Where;
      if (_settings.PermissionOption == AmlSqlPermissionOption.LegacyFunction
          && _renderOption != AmlSqlRenderOption.CountQuery
          && _renderOption != AmlSqlRenderOption.OffsetQuery)
      {
        clause = AppendCriteria(clause, new LegacyPermissionFunction(query));
      }
      return clause;
    }

    private IExpression AppendCriteria(IExpression orig, IExpression additional)
    {
      if (orig == null)
        return additional;
      return new AndOperator()
      {
        Left = orig,
        Right = additional
      };
    }

    private void AddJoinsToCriteria(QueryItem query, IList<IExpression> criteria)
    {
      foreach (var join in query.Joins.Where(j => j.GetCardinality() == Cardinality.OneToOne))
      {
        if (join.Right.Where != null
          || (join.Type == JoinType.Inner
            && _settings.PermissionOption == AmlSqlPermissionOption.LegacyFunction
            && _renderOption != AmlSqlRenderOption.CountQuery
            && _renderOption != AmlSqlRenderOption.OffsetQuery))
        {
          TryFillName(join.Right);
          criteria.Add(AddPermissionCheck(join.Right));
        }
        AddJoinsToCriteria(join.Right, criteria);
      }
    }

    private void VisitOrderBy(QueryItem query)
    {
      var orderBy = GetOrderBy(query);
      _writer.Write(" order by ");
      var first = true;
      foreach (var prop in orderBy)
      {
        if (!first)
          _writer.Write(", ");
        first = false;
        Visit(prop);
      }
    }

    private IEnumerable<OrderByExpression> GetOrderBy(QueryItem query)
    {
      if (query.OrderBy.Count > 0)
        return query.OrderBy;

      var props = _settings.GetProperties(query.Type).Values;
      var orderProps = props
          .OfType<Model.Property>()
          .Where(p => p.OrderBy().HasValue())
          .OrderBy(p => p.OrderBy().AsInt(int.MaxValue))
          .Select(p => new OrderByExpression()
          {
            Expression = new PropertyReference(p.NameProp().Value, query)
          })
          .ToArray();

      if (orderProps.Length > 0)
        return orderProps;

      return new[]
      {
        new OrderByExpression()
        {
          Expression = new PropertyReference("id", query)
        }
      };
    }

    private void Visit(OrderByExpression op)
    {
      op.Expression.Visit(this);
      if (!op.Ascending)
        _writer.Write(" DESC");
    }

    private void AddParenthesesIfNeeded(IOperator op, Action render)
    {
      var paren = _operators.Count > 0 && _operators.Peek().Precedence > op.Precedence;

      if (paren)
        _writer.Write('(');
      _operators.Push(op);

      render();

      _operators.Pop();
      if (paren)
        _writer.Write(')');
    }

    public void Visit(AndOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" and ");
        op.Right.Visit(this);
      });
    }

    public void Visit(BetweenOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" between ");
        op.Min.Visit(this);
        _writer.Write(" and ");
        op.Max.Visit(this);
      });
    }

    public void Visit(BooleanLiteral op)
    {
      _writer.Write('\'');
      _writer.Write(_context.Format(op.Value));
      _writer.Write('\'');
    }

    public void Visit(DateTimeLiteral op)
    {
      _writer.Write('\'');
      _writer.Write(_context.Format(op.Value));
      _writer.Write('\'');
    }

    public void Visit(EqualsOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" = ");
        op.Right.Visit(this);
      });
    }

    public void Visit(FloatLiteral op)
    {
      _writer.Write(_context.Format(op.Value));
    }

    public void Visit(FunctionExpression op)
    {
      var name = op.Name;
      switch (name.ToLowerInvariant())
      {
        case "getdate":
          name = "GetUtcDate";
          break;
      }
      _writer.Write(name);
      _writer.Write('(');
      var first = true;
      foreach (var arg in op.Args)
      {
        if (!first)
          _writer.Write(", ");
        first = false;
        arg.Visit(this);
      }
      _writer.Write(')');
    }

    public void Visit(GreaterThanOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" > ");
        op.Right.Visit(this);
      });
    }

    public void Visit(GreaterThanOrEqualsOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" >= ");
        op.Right.Visit(this);
      });
    }

    public void Visit(InOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" in ");
        op.Right.Visit(this);
      });
    }

    public void Visit(IntegerLiteral op)
    {
      _writer.Write(_context.Format(op.Value));
    }

    public void Visit(IsOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" is ");
        switch (op.Right)
        {
          case IsOperand.Null:
          case IsOperand.NotDefined:
            _writer.Write("null");
            break;
          default:
            _writer.Write("not null");
            break;
        }
      });
    }

    public void Visit(LessThanOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" < ");
        op.Right.Visit(this);
      });
    }

    public void Visit(LessThanOrEqualsOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" <= ");
        op.Right.Visit(this);
      });
    }

    public void Visit(LikeOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" like ");
        op.Right.Visit(this);
      });
    }

    public void Visit(ListExpression op)
    {
      _writer.Write('(');
      var first = true;
      foreach (var arg in op.Values)
      {
        if (!first)
          _writer.Write(", ");
        first = false;
        arg.Visit(this);
      }
      _writer.Write(')');
    }

    public void Visit(NotBetweenOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" not between ");
        op.Min.Visit(this);
        _writer.Write(" and ");
        op.Max.Visit(this);
      });
    }

    public void Visit(NotEqualsOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" <> ");
        op.Right.Visit(this);
      });
    }

    public void Visit(NotInOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" not in ");
        op.Right.Visit(this);
      });
    }

    public void Visit(NotLikeOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" not like ");
        op.Right.Visit(this);
      });
    }

    public void Visit(NotOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        _writer.Write(" not ");
        op.Arg.Visit(this);
      });
    }

    public void Visit(ObjectLiteral op)
    {
      op.Normalize(_settings).Visit(this);
    }

    public void Visit(OrOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" or ");
        op.Right.Visit(this);
      });
    }

    public void Visit(PropertyReference op)
    {
      if (op.Name.StartsWith("xp-"))
        throw new NotSupportedException();
      WriteAlias(op.Table);
      _writer.Write(".[");
      _writer.Write(op.Name);
      _writer.Write(']');
    }

    public void Visit(StringLiteral op)
    {
      if (op.Value.IsGuid())
        _writer.Write('\'');
      else
        _writer.Write("N'");
      _writer.Write(op.Value.Replace("'", "''"));
      _writer.Write('\'');
    }

    private void Visit(LegacyPermissionFunction perm)
    {
      WritePermissionCheck(() => WriteAlias(perm.Table));
    }

    private void WritePermissionCheck(Action writeAlias)
    {
      _writer.Write("( SELECT p FROM innovator.[");
      _writer.Write(_settings.PermissionOption == AmlSqlPermissionOption.LegacyFunction ? "GetDiscoverPermissions" : "EvaluatePermissions");
      _writer.Write("] ('can_get', ");
      writeAlias();
      _writer.Write(".permission_id, ");
      writeAlias();
      _writer.Write(".created_by_id, ");
      writeAlias();
      _writer.Write(".managed_by_id, ");
      writeAlias();
      _writer.Write(".owned_by_id, ");
      writeAlias();
      _writer.Write(".team_id, '");
      _writer.Write(_settings.IdentityList);
      _writer.Write("', null, '");
      _writer.Write(_settings.UserId);
      _writer.Write("', '8FE5430B42014D94AE83246F299D9CC4', '9200A800443E4A5AAA80D0BCE5760307', '538B300BB2A347F396C436E9EEE1976C' ) ) > 0");
    }

    public void Visit(MultiplicationOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" * ");
        op.Right.Visit(this);
      });
    }

    public void Visit(DivisionOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" / ");
        op.Right.Visit(this);
      });
    }

    public void Visit(ModulusOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" % ");
        op.Right.Visit(this);
      });
    }

    public void Visit(AdditionOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" + ");
        op.Right.Visit(this);
      });
    }

    public void Visit(SubtractionOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" - ");
        op.Right.Visit(this);
      });
    }

    public void Visit(NegationOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        _writer.Write(" -");
        op.Arg.Visit(this);
      });
    }

    public void Visit(ConcatenationOperator op)
    {
      AddParenthesesIfNeeded(op, () =>
      {
        op.Left.Visit(this);
        _writer.Write(" + ");
        op.Right.Visit(this);
      });
    }

    public void Visit(ParameterReference op)
    {
      _writer.Write('@');
      _writer.Write(op.Name);
    }

    public void Visit(AllProperties op)
    {
      if (op.XProperties)
        throw new NotSupportedException();
      WriteAlias(op.Table);
      _writer.Write(".*");
    }

    private class LegacyPermissionFunction : IExpression
    {
      public QueryItem Table { get; }

      public LegacyPermissionFunction(QueryItem table)
      {
        Table = table;
      }

      public void Visit(IExpressionVisitor visitor)
      {
        ((SqlServerVisitor)visitor).Visit(this);
      }
    }
  }
}
