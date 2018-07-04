using System;

namespace MainCalculator
{
    public class Tan : IOneArgumentCalculator
    {
       public double  Calculate(double thirdArgument)
       {
           return Math.Tan(thirdArgument);
       }
    }
}
