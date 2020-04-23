using DesignPatternsProject.AbstractFactory;
using DesignPatternsProject.model;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Decorator
{
    class BasePizza : IPizza
    {
        public EToppingType eTopping { get ; set ; }
        public int Price { get ; set  ; }
        public PizzaDough dough { get ; set ; }

        public BasePizza()
        {
            eTopping = EToppingType.EBasic;
            SetAccesories();
        }
        public void Assemble(AbstractDoughFactory abstractDoughFactory)
        {
            dough= abstractDoughFactory.GetPizzaDough();
        }

        public void SetAccesories()
        {
            Price = 0;
        }

        void IPizza.ToString()
        {
            Console.WriteLine("Price :" + Price + dough.price);
        }
    }
}
