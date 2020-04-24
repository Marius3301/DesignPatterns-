﻿using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public class CrustyDough : PizzaDough
    {
        public override EDoughType doughType { get ; set ; }

        public CrustyDough(EDoughType type,int price)
            :base(price)
        {
            doughType = type;
        }
    }
}
