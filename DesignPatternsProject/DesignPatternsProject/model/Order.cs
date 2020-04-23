using DesignPatternsProject.OrderStates;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public class Order
    {
        public List<Pizza> _pizzas;

        private OrderState _orderState;

        public Order()
        {
            _pizzas = new List<Pizza>();
            _orderState = new EmptyOrderState(this);
        }

        public void UpdateState(EClientOption option)
        {
            switch (option)
            {
                case EClientOption.AddPizza:
                    this.AddPizza();
                    break;
                case EClientOption.DeletePizza:
                    this.DeletePizza();
                    break;
                case EClientOption.SendOrder:
                    this.SendOrder();
                    break;
                case EClientOption.CheckOrderState:
                    this.CheckOrderState();
                    break;
                case EClientOption.CancelOrder:
                    this.CancelOrder();
                    break;
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

        public void CheckOrderState()
        {
            _orderState.CheckOrderState();
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
                    this._orderState = new EmptyOrderState(this);
                    break;
            }
        }

        public void ClearOrder()
        {
            _pizzas.Clear();
        }

        public double GetTotalPrice()
        {
            double result = 0;
            /*
            foreach(var pizza in _pizza) 
                result += pizza.GetPrice();
             */
            return result;
        }
    }
}
