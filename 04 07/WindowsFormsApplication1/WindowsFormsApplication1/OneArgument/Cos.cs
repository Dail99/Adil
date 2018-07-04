using System;
namespace MainCalculator
{
    public class Cos : IOneArgumentCalculator
    {
        public double Calculate(double thirdArgument)
        {
            return Math.Cos(thirdArgument);
        }
    }
}
