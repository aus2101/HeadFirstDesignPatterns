﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternPizzaStoreExample.IngredientConcreteClasses
{
    public class MozarellaCheese : Cheese
    {
        public MozarellaCheese()
        {
            Console.WriteLine("Adding some MozarellaCheese");
        }
    }
}