using DesignPatternsProject.OrderStates;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.Decorator;

namespace DesignPatternsProject.model
{
    public class Order
    {
        private OrderState _orderState;

        public List<IPizza> Pizzas { get; set; }
        public bool IsDelivered { get; set; }

        public Order()
        {
            _orderState = new EmptyOrderState(this);

            Pizzas = new List<IPizza>();
            IsDelivered = false;
        }

        public bool UpdateState(EClientOption option)
        {
            switch (option)
            {
                case EClientOption.AddPizza:
                    return AddPizza();

                case EClientOption.DeletePizza:
                    return DeletePizza();

                case EClientOption.SendOrder:
                    return SendOrder();

                case EClientOption.CheckOrderState:
                    return CheckOrderState();

                case EClientOption.CancelOrder:
                    return CancelOrder();

                default:
                    return false;
            }
        }
        public bool AddPizza()
        {
            return _orderState.AddPizza();
        }

        public bool DeletePizza()
        {
            return _orderState.DeletePizza();
        }

        public bool SendOrder()
        {
            return _orderState.SendOrder();
        }

        public bool CheckOrderState()
        {
            _orderState.CheckOrderState();

            return true;
        }

        public bool CancelOrder()
        {
            return _orderState.CancelOrder();
        }
        public void SetOrderState(EOrderStateType state)
        {
            switch (state)
            {
                case EOrderStateType.EmptyOrderState:
                    this._orderState = new EmptyOrderState(this);
                    break;
                case EOrderStateType.ReadyState:
                    this._orderState = new ReadyState(this);
                    break;
                case EOrderStateType.CookingState:
                    this._orderState = new CookingState(this);
                    break;
                case EOrderStateType.DeliveryState:
                    this._orderState = new DeliveryState(this);
                    break;
            }
        }

        public void ClearOrder()
        {
            Pizzas.Clear();
            IsDelivered = false;
            SetOrderState(EOrderStateType.EmptyOrderState);
        }

        public decimal GetTotalPrice()
        {
            decimal result = 0;
            
            foreach(var pizza in Pizzas) 
                result += pizza.TotalPrice();
             
            return result;
        }
    }
}
