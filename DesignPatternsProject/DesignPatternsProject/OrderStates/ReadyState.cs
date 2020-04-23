﻿using DesignPatternsProject.model;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.OrderStates
{
    public class ReadyState : OrderState
    {
        public ReadyState(Order order) : base(order)
        {
            //empty
        }
        public override bool AddPizza()
        {
            // TO DO : go to Pizza building menu
            // this.order.AddPizza(newPizza);

            order.SetOrderState(EOrderStateType.ReadyState);
            Console.WriteLine("Pizza was added to the order");
            return true;
        }

        public override bool CancelOrder()
        {
            string input = String.Empty;
            while (!input.Equals("y") && !input.Equals("n"))
            {
                Console.WriteLine("Are you sure you want to cancel your order? (y/n)");
                input = Console.ReadLine();
            }

            if (input.Equals("y"))
            {
                Console.WriteLine("Your order has been cleared");
                order.ClearOrder();
                order.SetOrderState(EOrderStateType.EmptyOrderState);
                return true;
            }
            else
                return false;
        }

        public override void CheckOrderState()
        {
            Console.WriteLine("Here are your pizzas");
            foreach (var pizza in this.order._pizzas)
            {
                Console.WriteLine(pizza.ToString());
            }
            Console.WriteLine($"Total price:{order.GetTotalPrice()}");
        }

        public override bool DeletePizza()
        {
            int input = -1;
            bool validInput = false;
            while (input != 0 && !validInput)
            {
                Console.WriteLine("Which pizza do you want to remove from your order:");
                for(int index = 0; index < order._pizzas.Count; index++)
                    Console.WriteLine($"{index + 1}. {order._pizzas[index].ToString()}");

                input = int.Parse(Console.ReadLine());
                validInput = IsValidInput(input);
            }

            if(validInput)
            {
                order._pizzas.RemoveAt(input - 1);
                Console.WriteLine("Pizza succesfully removed from your order");

                if (order._pizzas.Count == 0)
                    order.SetOrderState(EOrderStateType.EmptyOrderState);

                return true;
            }

            return false;
        }

        public override bool SendOrder()
        {
            // TO DO: Notify cook
            order.SetOrderState(EOrderStateType.CookingState);
            return true;
        }

        private bool IsValidInput(int input)
        {
            if (input > 0 && input <= order._pizzas.Count)
                return true;

            return false;
        }
    }
}

