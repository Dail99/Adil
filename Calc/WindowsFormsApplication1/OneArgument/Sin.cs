using System;


namespace MainCalculator
{
    public class Sin : IOneArgumentCalculator
    {
        /// <summary>
        /// Sinus count
        /// </summary>
        /// <param name="thirdArgument"></param>
        /// <returns>
        /// thirdArgument
        /// </returns>
        public double Calculate(double thirdArgument)
        {
            return Math.Sin(thirdArgument);
        }
    }
}
