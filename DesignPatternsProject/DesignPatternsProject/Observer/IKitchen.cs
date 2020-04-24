using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Observer
{
    public interface IKitchen
    {
        bool PlaceInOven(Order order, IDeliveryMan deliveryMan);

        void Cook(Order order);
        bool CancelOrder(Order order);

        void NotifyOrderFinish(Order order);
    }
}
