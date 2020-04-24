using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.Decorator;
using DesignPatternsProject.AbstractFactory;
using DesignPatternsProject.Calculation;
using DesignPatternsProject.model;

namespace DesignPatternsProject.utils
{
    public class OrderUtils
    {
        static public IPizza ChosePizza()
        {
            IPizza pizza = new BasePizza();
            IPizza decoPizza=null;
            int optionNumber = 0;
            Console.WriteLine("Please chose a pizza topping : \n" +
                "1.Carnivora  Price : 15 \n" +
                "2. MexicanPizza Price: 12 \n" +
                "3. QuattroStagioni Price 20 \n" +
                "4. Cancel");
            optionNumber = Convert.ToInt32(Console.ReadLine());
            switch(optionNumber)
            {
                case 1:
                    decoPizza = new CarnivoraPizzaDecorator(pizza);
                    break;
                case 2:
                    decoPizza = new MexicanPizzaDecorator(pizza);
                    break;
                case 3:
                    decoPizza = new QuattroStagioniPizzaDecorator(pizza);
                    break;
                case 4:
                    break;
                default:
                    break;
            }

            if (decoPizza != null)
            {
                Console.WriteLine("Please chose a pizza dough : \n" +
                   "1.Normal   Price : "+ Constans.NORMAL_DOUGH_PRICE + "\n" +
                   "2.Crusty   Price : "+Constans.CRUSTY_DOUGH_PRICE +"\n" +
                   "3.Chessy   Price : "+Constans.CHEESY_DOUGH_PRICE +" \n");
                optionNumber = Convert.ToInt32(Console.ReadLine());
                switch (optionNumber)
                {
                    case 1:
                        decoPizza.Assemble(new NormalDoughFactory());
                        break;
                    case 2:
                        decoPizza.Assemble(new CrustyDoughFactory());
                        break;
                    case 3:
                        decoPizza.Assemble(new CheesyDoughFactory());
                        break;
                    default:
                        break;
                }
            }
            return decoPizza;
        }

        static public void PayForOrderMenu(CashierInvoker cashierInvoker, Order order)
        {
            var price = order.GetTotalPrice();
            Console.WriteLine($"Your order price:{price}");
            Console.WriteLine("Pay exact sum? (y/n)");
            string input = Console.ReadLine();

            if (input.Equals("y"))
                cashierInvoker.Compute(ECommandType.Add, price);
            
            else if (input.Equals("n"))
            {
                decimal inputSum = 0;
                while (inputSum < price)
                {
                    Console.WriteLine("Enter a valid sum \n");
                    inputSum = Convert.ToInt32(Console.ReadLine());
                }

                decimal change = inputSum - price;

                cashierInvoker.Compute(ECommandType.Add, price);
                cashierInvoker.Compute(ECommandType.Substract, change);
            }

            Console.WriteLine("Thanks for choosing us! \n");
        }

        static public bool PlaceAnotherOrderPrompt()
        {
            string input = String.Empty;
            while (!input.Equals("y") && !input.Equals("n"))
            {
                Console.WriteLine("Do you want to place another order? (y/n)");
                input = Console.ReadLine();
            }

            if (input.Equals("y"))
                return true;
            else
                return false;
        }
    }
}
