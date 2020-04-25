using DesignPatternsProject.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public abstract class DeliveryMan : IDeliveryMan
    {
        public DeliveryMan _superiorDelivery;

        public abstract void Deliver(Order order);

        public abstract IDeliveryMan TryAssign(Order order);

        public abstract bool ApproveAssign(Order order);

        public abstract int GetMaxPriceOfOrder();

    }
}
