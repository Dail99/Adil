using System;

namespace MainCalculator
{
    public class Tan : IOneArgumentCalculator
    {
        /// <summary>
        /// Tangent count
        /// </summary>
        /// <param name="thirdArgument"></param>
        /// <returns>
        /// thirdArgument
        /// </returns>
        public double  Calculate(double thirdArgument)
       {
           return Math.Tan(thirdArgument);
       }
    }
}
