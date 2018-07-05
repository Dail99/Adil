
using System;
using NUnit.Framework;

namespace MainCalculator.Tests.FactoryTest
{
    public class FactoryTwoArgTest
    {
        [TestCase("plusSolution", typeof(Plus))]
        [TestCase("minSolution", typeof(Minus))]
        [TestCase("multiSolution", typeof(Multi))]
        [TestCase("delSolution", typeof(Div))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoTwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }

}
