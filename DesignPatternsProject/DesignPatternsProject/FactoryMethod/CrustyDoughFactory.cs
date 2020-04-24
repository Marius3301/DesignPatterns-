using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.AbstractFactory
{
    public class CrustyDoughFactory : DoughFactory
    {
        public override PizzaDough GetPizzaDough()
        {
            return new  CrustyDough(EDoughType.ECrusty, Constans.CRUSTY_DOUGH_PRICE);
        }
    }
}
