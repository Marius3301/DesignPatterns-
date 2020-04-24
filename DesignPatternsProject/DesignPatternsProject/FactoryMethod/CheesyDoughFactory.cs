using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.AbstractFactory
{
    public class CheesyDoughFactory : DoughFactory
    {
        public override PizzaDough GetPizzaDough()
        {
            return new ChessyDough( Constans.CHEESY_DOUGH_PRICE);
        }
    }
}
