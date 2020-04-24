using DesignPatternsProject.Cash;
using DesignPatternsProject.model;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    public class Calculator
    {
        private Cashier cashier = new Cashier();
        public void DoOperation(decimal value)

        {
            string input = String.Empty;


            decimal[] PaperMoneyArr = new decimal[] { 500, 100, 50, 10, 5, 1 };
            decimal[] CoinMoneyArr = new decimal[] { 0.5M, 0.1M, 0.05M, 0.01M };


            Console.WriteLine("Exact sum? (y/n)");
            input = Console.ReadLine();


            if (input.Equals("y"))

            {

                TakeMoney(PaperMoneyArr, EMoneyType.Paper, ref value);
                TakeMoney(CoinMoneyArr, EMoneyType.Coin, ref value);
               
                
            }

            else if (input.Equals("n"))
            {
                

                decimal inputSum = 0;
                while(inputSum<value)
                { 
                    Console.WriteLine("Enter a valid sum \n");
                    inputSum= Convert.ToInt32(Console.ReadLine());
                }


                decimal change = inputSum - value;

                TakeMoney(PaperMoneyArr, EMoneyType.Paper, ref value);
                TakeMoney(CoinMoneyArr, EMoneyType.Coin, ref value);
               

                GiveMoney(PaperMoneyArr, EMoneyType.Paper, ref change);
                GiveMoney(CoinMoneyArr, EMoneyType.Coin, ref change);
            }

        }
        public void TakeMoney(decimal[] array, EMoneyType eMoneyType, ref decimal  value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var moneyValue = array[i];

                while (moneyValue <= value)
                {
                    value -= moneyValue;
                    cashier.CashIn(moneyValue, eMoneyType);
                    Console.WriteLine($"s a facut cash in pe suma de {moneyValue} de tip {eMoneyType}\n");
                }
            }
        }
        public void GiveMoney(decimal[] array, EMoneyType eMoneyType, ref decimal value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var moneyValue = array[i];
                if (moneyValue <= value)
                {
                    cashier.CashOut(moneyValue, eMoneyType);
                    value -= moneyValue;
                    Console.WriteLine($"s a facut cash out pe suma de {moneyValue} de tip {eMoneyType}\n");
                }


            }
        }




    }
}