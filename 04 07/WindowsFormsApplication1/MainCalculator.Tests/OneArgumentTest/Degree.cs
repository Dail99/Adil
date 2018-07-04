using NUnit.Framework;
namespace MainCalculator.Tests.OneArgumentTest
{
    [TestFixture]
    public class MultiTests
    {
        [Test]
        public void CalculateMultiTest()
        {
            IOneArgumentCalculator calculator = new Radical();
            double result = calculator.Calculate(16);
            Assert.AreEqual(4, result);
        }
    }

}