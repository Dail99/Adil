
namespace MainCalculator
{
    public class DegreeFraction : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument,double secondArgument)
        {
            return System.Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}
