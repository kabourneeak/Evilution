﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvilutionClass
{
    public class GenericMessage
    {
        public GenericMessage(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public string TargetScene { get; set; }
        public string TargetItem { get; set; }
    }
}
