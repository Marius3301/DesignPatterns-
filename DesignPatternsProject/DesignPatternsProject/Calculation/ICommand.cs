using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsProject
{
    public interface ICommand
    {
       // char Action { get; set; }

        decimal Operand { get; set; }

        void Execute();

    }
}
