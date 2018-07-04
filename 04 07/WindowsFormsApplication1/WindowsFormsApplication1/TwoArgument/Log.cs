
namespace MainCalculator
{
    public class Log : ITwoArgumentCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Log(firstArgument,secondArgument);
        }
 
    }
}
