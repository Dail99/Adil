using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DegreeFraction : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument,double secondArgument)
        {
            return System.Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}
