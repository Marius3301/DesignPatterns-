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
            eTopping = EToppingType.EQuattroStagioni;
            SetAccesories();
        }
        public override void SetAccesories()
        {
            Price+=12;
        }
    }
}
