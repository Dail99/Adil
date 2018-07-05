
namespace MainCalculator
{
    public class Log : ITwoArgumentCalculator
    {
        /// <summary>
        /// Log count
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>
        /// firstArgument
        /// secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return System.Math.Log(firstArgument,secondArgument);
        }
 
    }
}
