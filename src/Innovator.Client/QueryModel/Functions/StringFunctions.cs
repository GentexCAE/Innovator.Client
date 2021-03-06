using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovator.Client.QueryModel.Functions
{
  public class Contains : FunctionExpression
  {
    public Contains() : base(2) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
    public IExpression Find { get => _args[1]; set => _args[1] = value; }
  }

  public class EndsWith : FunctionExpression
  {
    public EndsWith() : base(2) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
    public IExpression Find { get => _args[1]; set => _args[1] = value; }
  }

  public class IndexOf_Zero : FunctionExpression
  {
    public IndexOf_Zero() : base(2) { }

    public IExpression Target { get => _args[0]; set => _args[0] = value; }
    public IExpression String { get => _args[1]; set => _args[1] = value; }
  }

  public class IndexOf_One : FunctionExpression
  {
    public IndexOf_One() : base(2) { }

    public IExpression Target { get => _args[0]; set => _args[0] = value; }
    public IExpression String { get => _args[1]; set => _args[1] = value; }
  }

  public class Left : FunctionExpression
  {
    public Left() : base(2) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
    public IExpression Length { get => _args[1]; set => _args[1] = value; }
  }

  public class Length : FunctionExpression
  {
    public Length() : base(1) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
  }

  public class LTrim : FunctionExpression
  {
    public LTrim() : base(1) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
  }

  public class NewGuid : FunctionExpression
  {
    public NewGuid() : base(0) { }

    public override IExpression Evaluate() => new StringLiteral(Guid.NewGuid().ToString());
  }

  public class Replace : FunctionExpression
  {
    public Replace() : base(3) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
    public IExpression Find { get => _args[1]; set => _args[1] = value; }
    public IExpression Substitute { get => _args[2]; set => _args[2] = value; }
  }

  public class Reverse : FunctionExpression
  {
    public Reverse() : base(1) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
  }

  public class Right : FunctionExpression
  {
    public Right() : base(2) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
    public IExpression Length { get => _args[1]; set => _args[1] = value; }
  }

  public class RTrim : FunctionExpression
  {
    public RTrim() : base(1) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
  }

  public class StartsWith : FunctionExpression
  {
    public StartsWith() : base(2) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
    public IExpression Find { get => _args[1]; set => _args[1] = value; }
  }

  public class Substring_Zero : FunctionExpression
  {
    public Substring_Zero() : base(3) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
    public IExpression Start { get => _args[1]; set => _args[1] = value; }
    public IExpression Length { get => _args[2]; set => _args[2] = value; }
  }

  public class Substring_One : FunctionExpression
  {
    public Substring_One() : base(3) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
    public IExpression Start { get => _args[1]; set => _args[1] = value; }
    public IExpression Length { get => _args[2]; set => _args[2] = value; }

    public static IExpression FromZeroBased(IExpression str, IExpression start, IExpression length = null)
    {
      if (length == null)
      {
        return new Substring_One()
        {
          String = str,
          Start = new AdditionOperator()
          {
            Left = start,
            Right = new IntegerLiteral(1)
          }.Normalize(),
          Length = new SubtractionOperator()
          {
            Left = new Length()
            {
              String = str
            },
            Right = start
          }.Normalize()
        };
      }
      else
      {
        return new Substring_One()
        {
          String = str,
          Start = new AdditionOperator()
          {
            Left = start,
            Right = new IntegerLiteral(1)
          }.Normalize(),
          Length = length
        };
      }
    }
  }

  public class ToLower : FunctionExpression
  {
    public ToLower() : base(1) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
  }

  public class ToUpper : FunctionExpression
  {
    public ToUpper() : base(1) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
  }

  public class Trim : FunctionExpression
  {
    public Trim() : base(1) { }

    public IExpression String { get => _args[0]; set => _args[0] = value; }
  }
}
