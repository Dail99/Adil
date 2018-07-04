using System;


namespace MainCalculator
{
    public class Sin : IOneArgumentCalculator
    {
        public double Calculate(double thirdArgument)
        {
            return Math.Sin(thirdArgument);
        }
    }
}
