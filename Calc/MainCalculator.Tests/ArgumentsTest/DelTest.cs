﻿
using System;
using NUnit.Framework;

namespace MainCalculator.Tests.ArgumentsTest
{
    [TestFixture]
    public class DelTest

    {
    [TestCase(7, 0, 1)]
    [TestCase(8, 4, 2)]
    [TestCase(14, -7, -2)]
    public void CalculateDelTestStrong(double firstValue, double secondValue, double expected)
    {
        ITwoArgumentCalculator calculator = new Div();
        double result = calculator.Calculate(firstValue, secondValue);
        Assert.AreEqual(expected, result);
      
    }

        [Test]
        public void CalculateDelTestStrongExpection()
        {
            ITwoArgumentCalculator calculator = TwoTwoArgumentsFactory.CreateCalculator("delSolution");
            Assert.Throws<Exception>(() => calculator.Calculate(7, 0));
        }
    }
}
