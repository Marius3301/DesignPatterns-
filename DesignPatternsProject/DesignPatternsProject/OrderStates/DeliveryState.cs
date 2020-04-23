using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.OrderStates
{
    public class DeliveryState : OrderState
    {
        public DeliveryState(Order order) : base(order)
        {
            //empty
        }
        public override bool AddPizza()
        {
            Console.WriteLine("Your order is being delivered");
            return false;
        }

        public override bool CancelOrder()
        {
            string input = String.Empty;
            while (!input.Equals("y") && !input.Equals("n"))
            {
                Console.WriteLine("Are you sure you want to cancel your order? (y/n)");
                input = Console.ReadLine();
            }

            if (input.Equals("y"))
            {
                Console.WriteLine("Your order has been cleared");
                order.ClearOrder();
                order.SetOrderState(EOrderStateType.EmptyOrderState);
                return true;
            }
            else
                return false;
        }

        public override void CheckOrderState()
        {
            Console.WriteLine("Your order is being delivered");
        }

        public override bool DeletePizza()
        {
            Console.WriteLine("Your order is being delivered");
            return false;
        }

        public override bool SendOrder()
        {
            Console.WriteLine("Your order is being delivered");
            return false;
        }
    }
}

