
using NUnit.Framework;

namespace MainCalculator.Tests.StrongTests
{
    [TestFixture]
    public class TanTestStrong
    {
        [TestCase(0, 0)]
        public void CalculateTanTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Tan();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}
