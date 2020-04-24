using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public class CoinMoney : Money
    {
        public override EMoneyType GetEmoney()
        {
            return EMoneyType.Coin;
        }

        public static bool IsSharedValue(decimal value)
        {
            return (value.CompareTo(0.01m) == 0 ||
                value.CompareTo(0.05m) == 0 ||
                value.CompareTo(0.1m) == 0 ||
                value.CompareTo(0.5m) == 0);
        }

    }
}
