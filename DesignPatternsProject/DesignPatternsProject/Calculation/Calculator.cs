using DesignPatternsProject.Cash;
using DesignPatternsProject.model;
using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    public class Calculator
    {   private Cashier cashier = new Cashier();
        public void DoOperation(decimal value)

        { 
            string input = String.Empty;
           
          
            decimal[] PaperMoneyArr = new decimal[] { 500,100,50,10,5,1};
            decimal[] CoinMoneyArr = new decimal[] { 0.5M, 0.1M, 0.05M, 0.01M };


            Console.WriteLine("Exact sum? (y/n)");
            input = Console.ReadLine();

            
            if (input.Equals("y"))

            {

                SubFunction(PaperMoneyArr, EMoneyType.Paper, value);
                //for (int i = 0; i < PaperMoneyArr.Length; i++)
                //{
                //    var moneyValue = PaperMoneyArr[i];

                //    while (moneyValue <= value)
                //    {
                //        value -= moneyValue;
                //        cashier.CashIn(moneyValue, EMoneyType.Paper);
                //        Console.WriteLine($"s a facut cash in pe suma de {moneyValue} de tip {EMoneyType.Paper}\n");
                //    }
                //}
                if (value != 0)
                {
                    for (int i = 0; i < CoinMoneyArr.Length; i++)
                    {
                        var moneyValue = CoinMoneyArr[i];

                        while (moneyValue <= value)
                        {
                            value -= moneyValue;
                            cashier.CashIn(moneyValue, EMoneyType.Coin);
                            Console.WriteLine($"s a facut cash in pe suma de {moneyValue} de tip {EMoneyType.Coin}\n");

                        }
                    }
                }
            }

            else if (input.Equals("n"))
            {
                Console.WriteLine("introduceti suma \n");

                decimal inputSum = Convert.ToInt32(Console.ReadLine());
                if (inputSum < value)
                {
                    Console.WriteLine("Suma incorecta \n");
                    return;
                }


                decimal change = inputSum - value;

                for (int i = 0; i < PaperMoneyArr.Length; i++)
                {
                    var moneyValue = PaperMoneyArr[i];

                    while (moneyValue <= value)
                    {
                        value -= moneyValue;
                        cashier.CashIn(moneyValue, EMoneyType.Paper);
                        Console.WriteLine($"s a facut cash in pe suma de {moneyValue} de tip {EMoneyType.Paper}\n");

                    }
                }

                for (int i = 0; i < CoinMoneyArr.Length; i++)
                {
                    var moneyValue = CoinMoneyArr[i];

                    while (moneyValue <= value)
                    {
                        value -= moneyValue;
                        cashier.CashIn(moneyValue, EMoneyType.Coin);
                        Console.WriteLine($"s a facut cash in pe suma de {moneyValue} de tip {EMoneyType.Coin}\n");


                    }
                }

                for (int i = 0; i < PaperMoneyArr.Length; i++)
                {
                    var moneyValue = PaperMoneyArr[i];
                    if (moneyValue <= change)
                    {
                        cashier.CashOut(moneyValue, EMoneyType.Paper);
                        change -= moneyValue;
                        
                        Console.WriteLine($"s a facut cash out pe suma de {moneyValue} de tip {EMoneyType.Paper}\n");
                    }


                }
                for (int i = 0; i < CoinMoneyArr.Length; i++)
                {
                    var moneyValue = CoinMoneyArr[i];
                    if (moneyValue <= change)
                    {
                        change -= moneyValue;
                        cashier.CashOut(moneyValue, EMoneyType.Coin);
                        Console.WriteLine($"s a facut cash out pe suma de {moneyValue} de tip {EMoneyType.Paper}\n");
                    }


                }



            }

        }
            public void SubFunction(decimal[] array, EMoneyType eMoneyType, decimal value)
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
    }
}