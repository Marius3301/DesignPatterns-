using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.AbstractFactory
{
    public class CrustyDoughFactory : AbstractDoughFactory
    {
        public override PizzaDough GetPizzaDough()
        {
            return new PizzaDough(EDoughType.ECrusty, Constans.CRUSTY_DOUGH_PRICE);
        }
    }
}
