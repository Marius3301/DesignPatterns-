using DesignPatternsProject.Observer;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternsProject.model
{
    public class Kitchen : IKitchen
    {
        private Dictionary<Order, IDeliveryMan> _ordersInOven;

        public Kitchen()
        {
            _ordersInOven = new Dictionary<Order, IDeliveryMan>();
        }

        public bool PlaceInOven(Order order, IDeliveryMan deliveryMan)
        {
            if (_ordersInOven.ContainsKey(order))
                return false;

            Console.WriteLine("Order was sent to the kitchen");

            _ordersInOven.Add(order, deliveryMan);
            return true;
        }
        public bool CancelOrder(Order order)
        {
            if (!_ordersInOven.ContainsKey(order))
                return false;

            _ordersInOven.Remove(order);
            return true;
        }

        public void Cook(Order order)
        {
            Thread.Sleep(Constans.COOKING_TIME);

            if (_ordersInOven.ContainsKey(order))
                NotifyOrderFinish(order);
        }

        public void NotifyOrderFinish(Order order)
        {
            IDeliveryMan deliveryMan = _ordersInOven[order];
            order.SetOrderState(EOrderStateType.DeliveryState);

            deliveryMan.Deliver(order);
        }

    }
}
