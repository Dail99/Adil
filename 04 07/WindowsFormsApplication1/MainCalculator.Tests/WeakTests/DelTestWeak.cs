using NUnit.Framework;
namespace MainCalculator.Tests.TwoArgumentTest
{
    [TestFixture]
    public class DelTestWeak
    {
    [Test]
    public void CalculateDelTestWeak()
    {
        ITwoArgumentCalculator calculator = new Div();
        double result = calculator.Calculate(16,4);
        Assert.AreEqual(4, result);
    }
    }
}
