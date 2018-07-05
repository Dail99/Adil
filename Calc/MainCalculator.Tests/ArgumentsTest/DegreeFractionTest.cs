
using NUnit.Framework;

namespace MainCalculator.Tests.ArgumentsTest
{
    [TestFixture]
    public class DegreeFractionTest
    {
        [TestCase(5, 2, 2.5)]
        [TestCase(10,2 , 5)]
        [TestCase(15, 2, 7.5)]
        public void CalculateDegreeFractionTestStrong(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentCalculator calculator = new DegreeFraction();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}
