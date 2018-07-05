

namespace MainCalculator
{
    public class Radical : IOneArgumentCalculator
    {
        /// <summary>
        /// Radical Count
        /// </summary>
        /// <param name="radical"></param>
        /// <returns>
        /// Radical
        /// </returns>
        public double Calculate(double radical)
        {
            return System.Math.Sqrt(radical);
        }
    }
}
