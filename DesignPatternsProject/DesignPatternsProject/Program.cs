using System;
using DesignPatternsProject.AbstractFactory;
using DesignPatternsProject.model;
using DesignPatternsProject.utils;

namespace DesignPatternsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaDough pizza = null;

            AbstractDoughFactory abstractFactory = new NormalDoughFactory();

            pizza = abstractFactory.GetPizzaDough();

            Console.WriteLine(pizza.doughType + " " + pizza.price);

            abstractFactory = new CheesyDoughFactory();

            pizza = abstractFactory.GetPizzaDough();

            Console.WriteLine(pizza.doughType + " "+pizza.price);
        }
    }
}
