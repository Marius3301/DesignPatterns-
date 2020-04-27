using System;
using DesignPatternsProject.AbstractFactory;
using DesignPatternsProject.model;
using DesignPatternsProject.utils;
using DesignPatternsProject.Cash;
using DesignPatternsProject.Decorator;
using System.Threading;
using DesignPatternsProject.Calculation;

namespace DesignPatternsProject
{
    class Programm
    {

        static void Main(string[] args)
        {
            Kitchen kitchen = new Kitchen();
            CashierInvoker cashierInvoker = new CashierInvoker();
            FillRegister(cashierInvoker);

            PremiumDelivery premiumDelivery = new PremiumDelivery("Premium delivery");
            FastDelivery fastDelivery = new FastDelivery("Fast delivery", premiumDelivery);
            RegularDelivery regularDelivery = new RegularDelivery("Regular delivery", fastDelivery);

            Order order = new Order();
            Thread kitchenThread;

            bool shouldExit = false;
            int choice = -1;

            while (!shouldExit)
            {
                Console.WriteLine("Choose an option:");
                Console.Write("1. Add Pizza \n2. Delete Pizza \n3. Send Order \n" +
                    "4. Check Order State \n5. Cancel Order \n0. Exit  ");

                Console.WriteLine();
                choice = int.Parse(Console.ReadLine());

                if (!order.IsDelivered)
                {
                    switch (choice)
                    {
                        case 1:
                            order.UpdateState(EClientOption.AddPizza);
                            break;
                        case 2:
                            order.UpdateState(EClientOption.DeletePizza);
                            break;
                        case 3:
                            if (order.UpdateState(EClientOption.SendOrder))
                            {
                                if (kitchen.PlaceInOven(order, regularDelivery.TryAssign(order)))
                                {
                                    kitchenThread = new Thread(() => kitchen.Cook(order));
                                    kitchenThread.Start();
                                }
                            }
                            break;
                        case 4:
                            order.UpdateState(EClientOption.CheckOrderState);
                            break;
                        case 5:
                            if (order.UpdateState(EClientOption.CancelOrder))
                                kitchen.CancelOrder(order);
                            break;
                        case 0:
                            shouldExit = true;
                            break;
                        default:
                            Console.WriteLine("Please insert a valid choice");
                            break;
                    }
                }
                else
                {
                    OrderUtils.PayForOrderMenu(cashierInvoker, order);
                    if (OrderUtils.PlaceAnotherOrderPrompt())
                        order.ClearOrder();
                    else
                        shouldExit = true;
                }

                Console.WriteLine();
            }

        }

        static void FillRegister(CashierInvoker cashierInvoker)
        {
            cashierInvoker.Compute(ECommandType.Add, Constans.STARTING_REGISTER_MONEY,false);
        }
    }
}
