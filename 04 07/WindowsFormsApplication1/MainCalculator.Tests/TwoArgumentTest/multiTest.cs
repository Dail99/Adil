
using NUnit.Framework;

namespace MainCalculator.Tests
{
    [TestFixture]
    public class MultiTests
    {
        [Test]
        public void CalculateMultiTest()
        {
            ITwoArgumentCalculator calculator = new Multi();
            double result = calculator.Calculate(5, 10);
            Assert.AreEqual(50, result);
        }
    }

}
