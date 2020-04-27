using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;

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
            Console.WriteLine("Cannot cancel order while it is delivered");

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

