using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Cash
{
    public abstract class CashRegister
    {
        public Dictionary<decimal, Money> sharedMoneyMap { get; set; }
        //public decimal voucher { get; set; }
        //public Dictionary<decimal, Money> voucher {get; set;}

        public CashRegister()
        {
            sharedMoneyMap = new Dictionary<decimal, Money>();
           // voucher = 0;
        }

        protected Money Lookup(decimal value)
        {
            if (IsSharedValue(value))
            {
                if (!sharedMoneyMap.ContainsKey(value))
                {
                    sharedMoneyMap.Add(value, CreateNewMoney());
                    
                }
              return sharedMoneyMap[value];
            }
            
            return null; 
        }
        public void CashIn(decimal sum)
        {
            Money money = Lookup(sum);
            money.TotalValue += sum;
        }

        public void CashOut(decimal sum)
        {
            Money money = Lookup(sum);
            if (money.TotalValue >= sum)
            {
                money.TotalValue -= sum;
            }
            else
            {
                //voucher += sum;
                //Console.WriteLine($"{sum} was added in a voucher. total sum of the voucher is {voucher}");
                throw new Exception(); 
            }
        }

        public decimal GetTotalCache()
        {
            decimal sum = 0;
            foreach (var pair in sharedMoneyMap)
            {
                sum += pair.Value.TotalValue;
            }

            return sum;
        }

        public abstract Money CreateNewMoney();

        public abstract bool IsSharedValue(decimal value);
    }
}

