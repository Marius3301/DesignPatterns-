using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;
using DesignPatternsProject.model;
using DesignPatternsProject.AbstractFactory;

namespace DesignPatternsProject.Decorator
{
    public interface IPizza
    {
        public EToppingType eTopping { get; set; }

        public int Price { get; set; }

        public PizzaDough dough { get; set; }

        public void Assemble(DoughFactory abstractDoughFactory);

        public void SetAccesories();

        public string ToString();

        public int TotalPrice();

    }
}
