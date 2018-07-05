
namespace MainCalculator
{
    public class DegreeFraction : ITwoArgumentCalculator
    {
        /// <summary>
        /// DegreeFraction count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument,double secondArgument)
        {
            return System.Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}
