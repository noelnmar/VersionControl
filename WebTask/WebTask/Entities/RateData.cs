﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTask.Entities
{
    internal class RateData
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public decimal Value { get; set; }
    }
}
