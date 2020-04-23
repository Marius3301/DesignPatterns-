using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.OrderStates
{       
    public abstract class OrderState
    {
        protected Order order;
        public OrderState(Order order)
        {
            this.order = order;
        }
        public abstract bool AddPizza();
        public abstract bool DeletePizza();
        public abstract bool SendOrder();
        public abstract void CheckOrderState();
        public abstract bool CancelOrder();
    }
}
