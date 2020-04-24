using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.AbstractFactory
{
    public class NormalDoughFactory : AbstractDoughFactory
    {
        public override PizzaDough GetPizzaDough()
        {
            return new PizzaDough(EDoughType.ENormal, Constans.NORMAL_DOUGH_PRICE);
        }
    }
}
