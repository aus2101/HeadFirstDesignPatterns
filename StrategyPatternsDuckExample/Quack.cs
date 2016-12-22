﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsDuckExample
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("A real quack! - Quack behavior");
        }
    }
}
