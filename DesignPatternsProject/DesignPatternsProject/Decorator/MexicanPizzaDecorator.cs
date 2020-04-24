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
            DecoretedPizza.eTopping = EToppingType.EMexican;
            SetAccesories();
        }

        public override void SetAccesories()
        {
            DecoretedPizza.Price+=12;
        }
    }
}
