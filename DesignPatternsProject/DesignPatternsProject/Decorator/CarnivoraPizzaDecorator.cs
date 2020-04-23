using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.Decorator
{
    class CarnivoraPizzaDecorator:PizzaDecorator
    {
        public CarnivoraPizzaDecorator(IPizza pizza):base(pizza)
        {
            eTopping = EToppingType.ECarnivora;
            SetAccesories();
        }

        public override void SetAccesories()
        {
            Price+=15;
        }
    }
}
