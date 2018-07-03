using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Radical : OneArgumentCalculator
    {
        public double Calculate(double radical)
        {
            return System.Math.Sqrt(radical);
        }
    }
}
