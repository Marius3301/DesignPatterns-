using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.Decorator;
using DesignPatternsProject.AbstractFactory;

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
    }
}
