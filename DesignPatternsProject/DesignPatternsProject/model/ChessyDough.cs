using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public class ChessyDough : PizzaDough
    {
        public override EDoughType doughType { get => EDoughType.ECheesy; }

        public ChessyDough(int price):
            base(price)
        {
            
        }
    }
}
