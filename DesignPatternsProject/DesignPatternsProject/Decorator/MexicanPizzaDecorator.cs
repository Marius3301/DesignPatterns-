using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.Decorator
{
    class MexicanPizzaDecorator :PizzaDecorator
    {
        public MexicanPizzaDecorator(IPizza pizza): base(pizza)
        {
            pizza.eTopping = EToppingType.EMexican;
            SetAccesories();
        }

        public override void SetAccesories()
        {
            Price+=12;
        }
    }
}
