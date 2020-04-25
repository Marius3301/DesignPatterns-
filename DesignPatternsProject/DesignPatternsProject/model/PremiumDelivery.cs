using DesignPatternsProject.Observer;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternsProject.model
{
    public class PremiumDelivery : DeliveryMan
    {
        string _name;
        int _deliveryTime;

        public PremiumDelivery(string name)
        {
            _name = name;
            _deliveryTime = Constans.PREMIUM_DELIVERY_TIME;
            _superiorDelivery = null;
        }
        public override IDeliveryMan TryAssign(Order order)
        {
            return this;
        }

        public override bool ApproveAssign(Order order)
        {
            return true;
        }

        public override int GetMaxPriceOfOrder()
        {
            return int.MaxValue;
        }
        public override void Deliver(Order order)
        {
            Thread.Sleep(_deliveryTime);

            Console.WriteLine("Your order has been delivered by premium delivery, press any key to continue");
            order.IsDelivered = true;
        }
    }
}

