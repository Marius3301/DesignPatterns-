using DesignPatternsProject.AbstractFactory;
using DesignPatternsProject.model;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Decorator
{
    abstract class PizzaDecorator : IPizza
    {
        public EToppingType eTopping { get ; set ; }
        public int Price { get ; set ; }
        public PizzaDough dough { get ; set; }

        public IPizza DecoretedPizza { get; set; }

        public PizzaDecorator(IPizza pizza)
        {
            DecoretedPizza = pizza;
        }

        public void Assemble(DoughFactory abstractDoughFactory)
        {
            DecoretedPizza.Assemble(abstractDoughFactory);
        }

        public abstract void SetAccesories();

        public string ToString()
        {
            return DecoretedPizza.ToString();
        }

       

        public int TotalPrice()
        {
            return DecoretedPizza.Price + DecoretedPizza.dough.price;
        }
    }
}
