using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.model
{
    public class PizzaDough
    {
        public EDoughType doughType { get; set; }

        public int price { get; set; }

        public PizzaDough(EDoughType type, int price)
        {
            doughType = type;
            this.price = price;
        }
    }
}
