using NUnit.Framework;
using System;

namespace Module16.Final.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Addition_MustReturnCorrectValue()
        {
            int minValue = -1000;
            int maxValue = 1000;
            var calc = new Calculator();
            for (int i = minValue; i <= maxValue; i++)
            {
                Assert.AreEqual(i + i, calc.Addition(i, i));
                Assert.AreEqual(minValue + i + maxValue, calc.Addition(minValue, i, maxValue));
            }
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            int minValue = -1000;
            int maxValue = 1000;
            var calc = new Calculator();
            for (int i = minValue; i <= maxValue; i++)
            {
                Assert.AreEqual(maxValue - i, calc.Subtraction(maxValue, i));
            }
        }

        [Test]
        public void MultiplicationOfTwoAgrs_MustReturnCorrectValue()
        {
            int minValue = -1000;
            int maxValue = 1000;
            var calc = new Calculator();
            for (int i = minValue; i <= maxValue; i++)
            {
                Assert.AreEqual(i * i, calc.Miltiplication(i, i));
                Assert.AreEqual(minValue * i * maxValue, calc.Miltiplication(minValue, i, maxValue));
            }
        }

        [Test]
        public void MultiplicationOfTreeAgrs_MustReturnCorrectValue()
        {
            int minValue = -1000;
            int maxValue = 1000;
            var calc = new Calculator();
            for (int i = minValue; i <= maxValue; i++)
            {
                Assert.AreEqual(minValue * i * maxValue, calc.Miltiplication(minValue, i, maxValue));
            }
        }

        [Test]
        public void Division_ByZeroMustThrowException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(1000, 0));
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            int minValue = 1;
            int maxValue = 1000;
            var calc = new Calculator();
            for (int i = minValue; i <= maxValue; i++)
            {
                Assert.AreEqual(maxValue / i, calc.Division(maxValue, i));
            }
        }
    }
}
