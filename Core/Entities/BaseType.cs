﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssign3.Entities
{
    public abstract class BaseType : Entity
    {
        public Statuses Status { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
