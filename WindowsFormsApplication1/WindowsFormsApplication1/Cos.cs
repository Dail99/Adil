﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Cos : OneArgumentCalculator
    {
        public double Calculate(double thirdArgument)
        {
            return Math.Cos(thirdArgument);
        }
    }
}
