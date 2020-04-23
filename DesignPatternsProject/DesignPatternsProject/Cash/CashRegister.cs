using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Cash
{
    public abstract class CashRegister
    {
        public Dictionary<double, Money> sharedMoneyMap { get; set; }

        public CashRegister()
        {
            sharedMoneyMap = new Dictionary<double, Money>();
        }

        protected Money Lookup(double value)
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
        public void CashIn(double sum)
        {
            Money money = Lookup(sum);
            money.TotalValue += sum;
        }

        public void CashOut(double sum)
        {
            Money money = Lookup(sum);
            if (money.TotalValue >= sum)
            {
                money.TotalValue -= sum;
            }
            else
            {
                Console.WriteLine("Nu este posibil");
            }
        }

        public double GetTotalCache()
        {
            double sum = 0;
            foreach (var pair in sharedMoneyMap)
            {
                sum += pair.Value.TotalValue;
            }

            return sum;
        }

        public abstract Money CreateNewMoney();

        public abstract bool IsSharedValue(double value);
    }
}

