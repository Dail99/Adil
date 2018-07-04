

using NUnit.Framework;

namespace MainCalculator.Tests.TwoArgumentTest
{
    [TestFixture]
    public class MultiTestWeak
    {
        [Test]
        public void CalculateMultiTestWeak()
        {
            ITwoArgumentCalculator calculator = new Multi();
            double result = calculator.Calculate(16, 4);
            Assert.AreEqual(64, result);
        }
    }
}
