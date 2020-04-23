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

        public static bool IsSharedValue(double value)
        {
            return ((value == 0.01) || (value == 0.05) || (value == 0.1) || (value == 0.5));
        }

    }
}
