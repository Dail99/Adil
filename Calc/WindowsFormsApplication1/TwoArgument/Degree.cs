
namespace MainCalculator
{
    public class Degree : ITwoArgumentCalculator
    {
        /// <summary>
        /// Degree count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Pow(firstArgument, secondArgument);
        }
    }
}
