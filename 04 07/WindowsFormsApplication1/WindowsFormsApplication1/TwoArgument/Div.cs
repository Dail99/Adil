
namespace MainCalculator
{
    public class Div : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument , double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
