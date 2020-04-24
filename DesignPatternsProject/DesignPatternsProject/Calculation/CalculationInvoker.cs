using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    public class CalculationInvoker
    {

        private ICommand command;


        public CalculationInvoker()
        {
            this.command = new CalculationComand();
        }

        public void Compute(decimal value)
        {

            this.command.Operand = value;
            this.command.Execute();
        }



    }
}