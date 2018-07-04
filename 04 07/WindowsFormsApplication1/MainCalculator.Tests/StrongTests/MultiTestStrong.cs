
using NUnit.Framework;

namespace MainCalculator.Tests
{
    [TestFixture]
    public class MultiTestStrong
    {
        [TestCase(7, 0, 0)]
        [TestCase(3, 4, 12)]
        [TestCase(14, 2, 28)]
        public void CalculateMultiTestStrong(double firstValue,double secondValue,double expected)
        {
            ITwoArgumentCalculator calculator = new Multi();
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected,result);

        }
    }

}
