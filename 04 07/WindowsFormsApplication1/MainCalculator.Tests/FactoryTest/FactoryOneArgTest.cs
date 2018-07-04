
using System;
using NUnit.Framework;

namespace MainCalculator.Tests.FactoryTest
{
    public class FactoryOneArgTest
    {
        [TestCase("radicalSolution", typeof(Radical))]
        [TestCase("sinSolution", typeof(Sin))]
        [TestCase("cosSolution", typeof(Cos))]
        [TestCase("tanSolution", typeof(Tan))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);

        }
    }
}
