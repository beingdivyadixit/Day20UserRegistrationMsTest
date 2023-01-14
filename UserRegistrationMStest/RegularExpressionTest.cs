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
    }
}
