using DesignPatternsProject.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Cash
{
    public class CashRegisterPaper : CashRegister
    {
        public override Money CreateNewMoney()
        {
            return new PaperMoney();
        }

        public override bool IsSharedValue(decimal value)
        {
            return PaperMoney.IsSharedValue(value);
        }
    }
}
