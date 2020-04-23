using System;
using DesignPatternsProject.AbstractFactory;
using DesignPatternsProject.model;
using DesignPatternsProject.utils;
using DesignPatternsProject.Cash;

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
        
            Cashier cashier = new Cashier();
            cashier.CashIn(10, EMoneyType.Paper);
            cashier.CashOut(10, EMoneyType.Paper);

            cashier.CashOut(5, EMoneyType.Paper);

            cashier.CashIn(0.1, EMoneyType.Coin);
            Console.WriteLine(cashier.GetTotalCache());
        }
    }
}
