
using NUnit.Framework;

namespace MainCalculator.Tests.ArgumentsTest
{
    [TestFixture]
    public class CosTest
    {
        [TestCase(0, 1)]
        [TestCase(90,0)]
        [TestCase(180,-1)]
        public void CalculateCosTestStrong(double firstValue, double expected)
        {
            IOneArgumentCalculator calculator = new Cos();
            double result = calculator.Calculate(firstValue);
            Assert.AreEqual(expected, result);

        }
    }
}
