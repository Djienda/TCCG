﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [Serializable]
    public class DataHolder
    {
        public Dictionary<Type, List<AEntity>> db;
    }
}
