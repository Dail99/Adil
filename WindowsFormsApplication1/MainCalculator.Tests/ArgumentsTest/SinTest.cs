
using NUnit.Framework;

namespace MainCalculator.Tests.ArgumentsTest
{
    [TestFixture]
    public class SinTest
    {
        [TestCase(0, 0)]
        [TestCase(90,1)]
        [TestCase(180,0)]
        public void CalculateSinTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Sin();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}
