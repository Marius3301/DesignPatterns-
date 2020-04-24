using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.model
{
    public class PaperMoney:Money
    {
        public override EMoneyType GetEmoney()
        {
            return EMoneyType.Paper;
        }

        public static bool IsSharedValue(decimal value)
        {
            return ((value == 1) || (value == 5) || (value == 10) || (value == 50) || (value == 100) || (value == 500));
        }

    }
}
