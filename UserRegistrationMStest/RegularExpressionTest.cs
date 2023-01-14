using Day20UserRegistrationMsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;

namespace UserRegistrationMStest
{
    [TestClass]
    public class RegularExpressionTest
    {
        [TestMethod]
        [TestCategory("First Name")]
        [DataRow("Aditya","valid")]
        [DataRow("divya", "Invalid")]
        [DataRow("Divya", "valid")]
        [DataRow("aditya", "Invalid")]
        public void Should_Return_fisrtName_Is_Valid_Or_Not(string inputs, string expected)
        {   //AAA Methodology
            //Arrange
            RegularExpression regularExpression =new RegularExpression();

            //Act
            string actual = regularExpression.firstName(inputs);
            
            //Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow("Dixit", "valid")]
        [DataRow("dixit", "Invalid")]
        public void Should_Return_lastName_Is_Valid_Or_Not(string inputs, string expected)
        {   //AAA Methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression();

            //Act
            string actual = regularExpression.lastName(inputs);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [TestCategory("Email")]
        [DataRow("abc.xyz@bl.co.in", "valid")]
        [DataRow("Abc.xyz@bl.co.in", "Invalid")]
        public void Should_Return_Email_Is_Valid_Or_Not(string inputs, string expected)
        {   //AAA Methodology
            //Arrange
            RegularExpression regularExpression = new RegularExpression();

            //Act
            string actual = regularExpression.email(inputs);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
