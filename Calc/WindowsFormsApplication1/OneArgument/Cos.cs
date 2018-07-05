using System;
namespace MainCalculator
{

    public class Cos : IOneArgumentCalculator
    {
        /// <summary>
        /// One Argument Calculator
        /// </summary>
        /// <param name="thirdArgument"></param>
        /// <returns>
        /// thirdArgument
        /// </returns>
        public double Calculate(double thirdArgument)
        {
            return Math.Cos(thirdArgument);
        }
    }
}
