using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Sin : OneArgumentCalculator
    {
        public double Calculate(double thirdArgument)
        {
            return Math.Sin(thirdArgument);
        }
    }
}
