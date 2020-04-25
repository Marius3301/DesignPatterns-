using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Cash
{
    class Cashier
    {
        public CashRegisterCoin CoinMoney { get; set; } = new CashRegisterCoin();

        public CashRegisterPaper PaperMoney { get; set; } = new CashRegisterPaper();


        private CashRegister GetCashRegister(EMoneyType type)
        {
            CashRegister obj = null;

            switch (type)
            {            
                case EMoneyType.Coin:
                    obj = CoinMoney;
                    break;
                case EMoneyType.Paper:
                    obj = PaperMoney;
                    break;
            }

            return obj;
        }

        public void CashIn(decimal value, EMoneyType type)
        {
            GetCashRegister(type).CashIn(value);
        }

        public void CashOut(decimal value, EMoneyType type)
        {
            GetCashRegister(type).CashOut(value);
        }

        public decimal GetTotalCache()
        {
            return CoinMoney.GetTotalCache() + PaperMoney.GetTotalCache();
        }
    }
}
