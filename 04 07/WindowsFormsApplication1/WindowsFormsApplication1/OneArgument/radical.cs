

namespace MainCalculator
{
    public class Radical : IOneArgumentCalculator
    {
        public double Calculate(double radical)
        {
            return System.Math.Sqrt(radical);
        }
    }
}
