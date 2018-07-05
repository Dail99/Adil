
using System;
using NUnit.Framework;

namespace MainCalculator.Tests.FactoryTest
{
    public class TwoArgumentsFactoryTest
    {
        [TestCase("plusSolution", typeof(Plus))]
        [TestCase("minSolution", typeof(Minus))]
        [TestCase("multiSolution", typeof(Multi))]
        [TestCase("delSolution", typeof(Div))]
        [TestCase("degreeSolution",typeof(Degree))]
        [TestCase("degreeFraction",typeof(DegreeFraction))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoTwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }

}
