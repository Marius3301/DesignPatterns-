using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    public class CalculationComand : ICommand
    {
        private Calculator calculator;

        public CalculationComand()
        {
            calculator = new Calculator();
        }
        public char Action { get; set; }
        public decimal Operand { get; set; }

        public void Execute()
        {
            calculator.DoOperation( this.Operand);
        }



    }
}