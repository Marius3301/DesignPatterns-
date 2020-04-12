using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.model;

namespace DesignPatternsProject.AbstractFactory
{
    abstract class AbstractDoughFactory
    {
        public abstract PizzaDough GetPizzaDough();
    }
}
