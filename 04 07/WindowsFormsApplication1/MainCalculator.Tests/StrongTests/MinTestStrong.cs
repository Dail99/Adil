
using NUnit.Framework;

namespace MainCalculator.Tests.TwoArgumentTest
{
    [TestFixture]
    public class MinTestStrong
    {
        [TestCase(7, 0, 7)]
        [TestCase(5, 4, 1)]
        [TestCase(6, 4, 2)]
        public void CalculateMinTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new Minus();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);

        }
    }
}
