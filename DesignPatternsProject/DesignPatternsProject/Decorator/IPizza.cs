﻿using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsProject.utils;
using DesignPatternsProject.model;
using DesignPatternsProject.AbstractFactory;

namespace DesignPatternsProject.Decorator
{
    interface IPizza
    {
        public EToppingType eTopping { get; set; }

        public int Price { get; set; }

        public PizzaDough dough { get; set; }

        public void Assemble(AbstractDoughFactory abstractDoughFactory);

        public void SetAccesories();

        public void ToString();
    }
}