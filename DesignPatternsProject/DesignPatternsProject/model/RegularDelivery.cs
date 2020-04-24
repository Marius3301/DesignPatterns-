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

        IDeliveryMan _superiorDelivery;
        public RegularDelivery(string name, IDeliveryMan superiorDelivery)
        {
            _name = name;
            _deliveryTime = Constans.REGULAR_DELIVERY_TIME;
            _superiorDelivery = superiorDelivery;
        }

        public IDeliveryMan TryAssign(Order order)
        {
            if (ApproveAssign(order))
                return this;

            return _superiorDelivery.TryAssign(order);
        }

        public bool ApproveAssign(Order order)
        {
            if (order.GetTotalPrice() > GetMaxPriceOfOrder())
                return false;

            return true;
        }

        public int GetMaxPriceOfOrder()
        {
            return Constans.MAX_PRICE_REGULAR_DELIVERY;
        }

        public void Deliver(Order order)
        {
            Thread.Sleep(_deliveryTime);

            Console.WriteLine("Your order has been delivered, press any key to continue");
            order.IsDelivered = true;
        }

    }
}
