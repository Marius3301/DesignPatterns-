using DesignPatternsProject.Observer;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternsProject.model
{
    public class RegularDelivery : IDeliveryMan
    {
        string _name;
        int _deliveryTime;

        public RegularDelivery(string name)
        {
            _name = name;
            _deliveryTime = Constans.REGULAR_DELIVERY_TIME;
        }
        public void Deliver(Order order)
        {
            Thread.Sleep(_deliveryTime);

            Console.WriteLine("Your order has been delivered, press any key to continue");
            order.IsDelivered = true;
        }
    }
}
