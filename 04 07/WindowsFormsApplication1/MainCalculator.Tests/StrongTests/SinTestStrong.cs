
using NUnit.Framework;

namespace MainCalculator.Tests.StrongTests
{
    [TestFixture]
    public class SinTestStrong
    {
        [TestCase(0, 0)]
        public void CalculateSinTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Sin();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}
