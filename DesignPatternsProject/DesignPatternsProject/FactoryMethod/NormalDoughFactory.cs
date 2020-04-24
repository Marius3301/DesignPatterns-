using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.AbstractFactory
{
    public class NormalDoughFactory : DoughFactory
    {
        public override PizzaDough GetPizzaDough()
        {
            return new NormalDough( Constans.NORMAL_DOUGH_PRICE);
        }
    }
}
