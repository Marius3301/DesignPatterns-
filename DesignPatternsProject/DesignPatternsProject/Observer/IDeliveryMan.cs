using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Observer
{
    public interface IDeliveryMan
    {
        public void Deliver(Order order);
    }
}
