using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Calculation
{
    public class CashierInvoker
    {
        private ICommand command;

        public CashierInvoker()
        {
            this.command = new CashierCommand();
        }

        public void Compute(ECommandType commandType, decimal value, bool displaySteps = true)
        {
            this.command.CommandType = commandType;
            this.command.Operand = value;
            this.command.DisplaySteps = displaySteps;

            this.command.Execute();
        }
    }
}
