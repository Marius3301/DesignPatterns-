using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.model
{
    public abstract class PizzaDough
    {
        public abstract EDoughType doughType { get; set; }

        public int price { get; set; }

        public PizzaDough(int price)
        {
            this.price = price;
        }
    }
}
