using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.model;


namespace DesignPatternsProject.Cash
{
    public class CashRegisterCoin : CashRegister
    {
        public override Money CreateNewMoney()
        {
            return new CoinMoney();
        }

        public override bool IsSharedValue(double value)
        {
            return CoinMoney.IsSharedValue(value);
        }
    }
}
