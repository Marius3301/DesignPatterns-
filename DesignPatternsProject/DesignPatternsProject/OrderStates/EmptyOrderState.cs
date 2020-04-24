using DesignPatternsProject.model;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.OrderStates
{
    public class EmptyOrderState : OrderState
    {
        public EmptyOrderState(Order order) : base(order)
        {
            //empty
        }
        public override bool AddPizza()
        {
            var newPizza = OrderUtils.ChosePizza();

            if (newPizza != null)
            {
                order.SetOrderState(EOrderStateType.ReadyState);

                order.Pizzas.Add(newPizza);
                Console.WriteLine("Pizza was added to the order");
                return true;
            }
            else
                return false;
        }

        public override bool CancelOrder()
        {
            Console.WriteLine("Order is empty therefore not sent, nothig to cancel");
            return true;
        }

        public override void CheckOrderState()
        {
            Console.WriteLine("Your order is empty");
        }

        public override bool DeletePizza()
        {
            Console.WriteLine("Your order is empty, nothing to delete");
            return false;
        }

        public override bool SendOrder()
        {
            Console.WriteLine("Your order is empty, nothing to send");
            return false;
        }
    }
}
