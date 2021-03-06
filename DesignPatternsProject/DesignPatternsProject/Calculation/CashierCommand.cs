﻿using DesignPatternsProject.Cash;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Calculation
{
    public class CashierCommand : ICommand
    {
        private Cashier cashier;

        decimal[] PaperMoneyArr = new decimal[] { 500, 100, 50, 10, 5, 1 };
        decimal[] CoinMoneyArr = new decimal[] { 0.5M, 0.1M, 0.05M, 0.01M };
        public CashierCommand()
        {
            cashier = new Cashier();
        }
        public ECommandType CommandType { get; set; }
        public decimal Operand { get; set; }
        public bool DisplaySteps { get; set; }

        public void Execute()
        {
            decimal transactionValue = Operand;
            switch (CommandType)
            {
                case ECommandType.Add:
                    TakeMoney(PaperMoneyArr, EMoneyType.Paper, ref transactionValue);
                    TakeMoney(CoinMoneyArr, EMoneyType.Coin, ref transactionValue);
                    break;
                case ECommandType.Substract:
                    GiveMoney(PaperMoneyArr, EMoneyType.Paper, ref transactionValue,true);
                    GiveMoney(CoinMoneyArr, EMoneyType.Coin, ref transactionValue, false);
                    break;
                default:
                    break;
            }
        }

        public void TakeMoney(decimal[] array, EMoneyType eMoneyType, ref decimal value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var moneyValue = array[i];

                while (moneyValue <= value)
                {
                    value -= moneyValue;
                    cashier.CashIn(moneyValue, eMoneyType);
                    if(DisplaySteps)
                        Console.WriteLine($"Cashier took  {moneyValue} of  {eMoneyType}\n");
                }
            }
        }

        public void GiveMoney(decimal[] array, EMoneyType eMoneyType, ref decimal value, bool isPaper)
        {
            decimal voucher = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var moneyValue = array[i];
                while(moneyValue <= value)
                {
                    try
                    {
                        cashier.CashOut(moneyValue, eMoneyType);

                        if (DisplaySteps)

                            Console.WriteLine($"Cashier give {moneyValue} de tip {eMoneyType}\n");
                    }
                    catch (Exception)
                    {
                        voucher += moneyValue;
                    }

                    value = value - moneyValue;
                }
            }
            if(isPaper==true)
                Console.WriteLine($" Congrats! You recived a voucher. The total of the voucher is: {voucher}\n");

        }
    }
}
