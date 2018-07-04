
namespace MainCalculator
{
    public class Degree : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Pow(firstArgument, secondArgument);
        }
    }
}
