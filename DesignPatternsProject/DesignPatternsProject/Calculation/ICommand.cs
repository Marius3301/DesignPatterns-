using DesignPatternsProject.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject.Calculation
{
    public interface ICommand
    {
        ECommandType CommandType { get; set; }
        decimal Operand { get; set; }

        bool DisplaySteps { get; set; }

        void Execute();

    }
}
