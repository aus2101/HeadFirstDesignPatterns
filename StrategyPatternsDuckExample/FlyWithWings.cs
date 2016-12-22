﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternsDuckExample
{
    public class FlyWithWings :FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Fly with wings!!");
        }

        
    }
}
