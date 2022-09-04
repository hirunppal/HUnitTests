using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUnit
{
    [TestFixture]
    public class CutomerUnitTests
    {

        private Customer customer;

    [SetUp]
    public void Setup()
    {
        customer = new Customer();
    }
  
        [Test]
        public void CombineName_InpFirstAndLastName_ReturnFullname()
        {
            //Arrange 
            var customer = new Customer();
            //Act
            string fullname = customer.GreetingCustomer("Ben", "Efflex");

            //Assert

            Assert.AreEqual(fullname, "hello,Ben Efflex");
            Assert.That(fullname, Is.EqualTo("hello,Ben Efflex"));
            Assert.That(fullname, Does.StartWith("hello"));
            Assert.That(fullname, Does.Contain(","));
            Assert.That(fullname, Does.Contain("Ben efflex").IgnoreCase);
            Assert.That(fullname, Does.Match("hello,[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
            Assert.That(fullname, !Does.Match("Hello,[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
        }
    }
}
