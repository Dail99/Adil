using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Div : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument , double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
