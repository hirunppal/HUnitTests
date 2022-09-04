using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUnit
{
    [TestFixture]
    public class CalculatorNUnitTest
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrentAddition()
        {
            //Arrange
            Calculator Calc = new();
            //Act
            int result = Calc.Addnumber(10, 20);
            //Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        public void IsOddChecker_InputEvenNumber_ReturnFalse()
        {
            //Arrange
            Calculator Calc = new();
            //Act
            bool isOdd = Calc.IsOddNumber(20);
            //Assert
            Assert.That(isOdd, Is.EqualTo(false));
            //assert.Isfalse(isOdd)
        }
        [Test]
        [TestCase(11)]
        [TestCase(15)]
        [TestCase(-9)]

        [TestCase(9)]
        public void IsOddChecker_InputOddNumber_ReturnTrue(int a)
        {
            //Arrange
            Calculator Calc = new();
            //Act
            bool isOdd = Calc.IsOddNumber(a);
            //Assert
            //Assert.That(isOdd, Is.EqualTo(false));
            Assert.IsTrue(isOdd);
        }
        [Test]
        [TestCase(8, ExpectedResult = false)]
        [TestCase(1, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTreuIfOdd(int a)
        {
            Calculator calc = new();
            return calc.IsOddNumber(a);
        }

        [Test]
        [TestCase(54.11, 10.09)] //64.20
        [TestCase(54.11, 10.092)]
        [TestCase(54.10, 10.092)]
        public void AddNumbersDubleTwoInt_GetCorrentAddition(double a, double b)
        {
            //Arrange
            Calculator Calc = new();
            //Act
            double result = Calc.AddNumberDouble(a, b);
            //Assert
            Assert.AreEqual(64.20, result,.1);
        }

    }
}
