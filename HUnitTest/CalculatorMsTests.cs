using HUnit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUnitTest
{
    [TestClass]
    public class CalculatorMsTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrentAddition()
        {
            //Arrange
            Calculator Calc = new();
            //Act
            int result = Calc.Addnumber(10, 20);
            //Assert
            Assert.AreEqual(30, result);
        }
    }
}
