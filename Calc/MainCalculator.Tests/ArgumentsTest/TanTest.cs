
using NUnit.Framework;

namespace MainCalculator.Tests.ArgumentsTest
{
    [TestFixture]
    public class TanTest
    {
        [TestCase(0, 0)]
        [TestCase(0,180)]
        [TestCase(0,360)]
        public void CalculateTanTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Tan();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}
