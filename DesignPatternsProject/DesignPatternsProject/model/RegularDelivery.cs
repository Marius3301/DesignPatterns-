using DesignPatternsProject.Observer;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternsProject.model
{
    public class RegularDelivery : DeliveryMan
    {
        string _name;
        int _deliveryTime;
        public RegularDelivery(string name, DeliveryMan superiorDelivery)
        {
            _name = name;
            _deliveryTime = Constans.REGULAR_DELIVERY_TIME;
            _superiorDelivery = superiorDelivery;
        }

        public override IDeliveryMan TryAssign(Order order)
        {
            if (ApproveAssign(order))
                return this;

            return _superiorDelivery.TryAssign(order);
        }

        public override bool ApproveAssign(Order order)
        {
            if (order.GetTotalPrice() > GetMaxPriceOfOrder())
                return false;

            return true;
        }

        public override int GetMaxPriceOfOrder()
        {
            return Constans.MAX_PRICE_REGULAR_DELIVERY;
        }

        public override void Deliver(Order order)
        {
            Thread.Sleep(_deliveryTime);

            Console.WriteLine("Your order has been delivered by regular delivery, press any key to continue");
            order.IsDelivered = true;
        }

    }
}
