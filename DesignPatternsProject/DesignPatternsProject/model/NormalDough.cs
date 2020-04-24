using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public class NormalDough : PizzaDough
    {
        public override EDoughType doughType { get => EDoughType.ENormal ; }

        public NormalDough(int price)
            :base(price)
        {
            
        }
    }
}
