
using NUnit.Framework;

namespace MainCalculator.Tests.ArgumentsTest
{
    [TestFixture]
    public class PlusTest
    {
        [TestCase(7, 0, 7)]
        [TestCase(3, 4, 7)]
        [TestCase(14, -7, 7)]
        public void CalculateMultiTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new Plus();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}
