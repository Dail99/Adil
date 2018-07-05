
using NUnit.Framework;

namespace MainCalculator.Tests.ArgumentsTest
{
    [TestFixture]
    public class Radical
    {
        [TestCase(4, 2)]
        [TestCase(16,4)]
        [TestCase(64,8)]
        public void CalculateRadicalTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Radical();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}
