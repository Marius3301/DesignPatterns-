using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

namespace DesignPatternsProject.Decorator
{
    class QuattroStagioniPizzaDecorator : PizzaDecorator
    {
        public QuattroStagioniPizzaDecorator(IPizza pizza):base(pizza)
        {
            DecoretedPizza.eTopping = EToppingType.EQuattroStagioni;
            SetAccesories();
        }
        public override void SetAccesories()
        {
            DecoretedPizza.Price+=20;
        }
    }
}
