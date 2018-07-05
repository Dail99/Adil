
using NUnit.Framework;

namespace MainCalculator.Tests.TwoArgumentTest
{
    [TestFixture]
    public class MinTestWeak
    {
        [Test]
        public void CalculateMinTestWeak()
        {
            ITwoArgumentCalculator calculator = new Minus();
            double result = calculator.Calculate(16, 4);
            Assert.AreEqual(12, result);
        }
    }
}
