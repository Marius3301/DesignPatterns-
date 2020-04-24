using DesignPatternsProject.Observer;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternsProject.model
{
    public class FastDelivery : IDeliveryMan
    {
        string _name;
        int _deliveryTime;

        public FastDelivery(string name)
        {
            _name = name;
            _deliveryTime = Constans.FAST_DELIVERY_TIME;
        }
        public void Deliver(Order order)
        {
            Thread.Sleep(_deliveryTime);

            Console.WriteLine("Your order has been delivered, press any key to continue");
            order.IsDelivered = true;
        }
    }
}
