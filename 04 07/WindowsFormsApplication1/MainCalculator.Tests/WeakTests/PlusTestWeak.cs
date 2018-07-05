
using NUnit.Framework;

namespace MainCalculator.Tests.TwoArgumentTest
{
    [TestFixture]
    public class PlusTestWeak
    {
        [Test]
        public void CalculatePlusTestWeak()
        {
            ITwoArgumentCalculator calculator = new Plus();
            double result = calculator.Calculate(16, 4);
            Assert.AreEqual(20, result);
        }
    }
}
