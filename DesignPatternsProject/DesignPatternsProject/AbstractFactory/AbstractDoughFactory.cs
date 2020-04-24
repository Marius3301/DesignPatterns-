using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.model;

namespace DesignPatternsProject.AbstractFactory
{
    public abstract class AbstractDoughFactory
    {
        public abstract PizzaDough GetPizzaDough();
    }
}
