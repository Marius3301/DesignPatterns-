using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public class NormalDough : PizzaDough
    {
        public override EDoughType doughType { get ; set ; }

        public NormalDough(EDoughType type , int price)
            :base(price)
        {
            doughType = type;
        }
    }
}
