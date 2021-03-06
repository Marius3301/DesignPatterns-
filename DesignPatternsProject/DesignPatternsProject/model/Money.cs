﻿using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public abstract class  Money
    {
        public decimal TotalValue { get; set; } = 0;
        public abstract EMoneyType GetEmoney();
    }
}
