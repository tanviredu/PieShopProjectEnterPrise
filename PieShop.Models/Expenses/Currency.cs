﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Models
{
    public class Currency
    {
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double USExcange { get; set; }

    }
}
