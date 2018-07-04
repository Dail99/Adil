
using NUnit.Framework;

namespace MainCalculator.Tests.TwoArgumentTest
{
    [TestFixture]
    public class DelTestStrong

    {
    [TestCase(7, 1, 7)]
    [TestCase(8, 4, 2)]
    [TestCase(14, -7, -2)]
    public void CalculateDelTestStrong(double firstValue, double secondValue, double expected)
    {
        ITwoArgumentCalculator calculator = new Div();
        double result = calculator.Calculate(firstValue, secondValue);
        Assert.AreEqual(expected, result);

    }
    }
}
