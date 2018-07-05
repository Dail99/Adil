
using NUnit.Framework;

namespace MainCalculator.Tests.StrongTests
{
    [TestFixture]
    public class RadicalTestStrong
    {
        [TestCase(4, 2)]
        public void CalculateRadicalTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Radical();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}
