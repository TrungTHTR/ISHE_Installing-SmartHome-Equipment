﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Survey :BaseEntity
    {
        public string? Description { get; set; }
        public string? Note { get; set; }
        
    }
}
