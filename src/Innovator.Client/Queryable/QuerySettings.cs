﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovator.Client
{
  public class QuerySettings
  {
    public Action<IItem> ModifyQuery { get; set; }
  }
}
