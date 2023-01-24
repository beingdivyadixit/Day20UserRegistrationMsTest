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
        [DataRow(new string[] { "Aditya", "Divya" }, true)]
        [DataRow(new string[] { "aditya", "divya" }, false)]
        public void Should_Return_fisrtName_Is_Valid_Or_Not(string[] inputs, bool expected)
        {   //AAA Methodology
            //Arrange
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.FirstName();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow(new string[] { "Dixit", "Mishra" }, true)]
        [DataRow(new string[] { "dixit", "mishra" }, false)]
        public void Should_Return_lastName_Is_Valid_Or_Not(string[] inputs, bool expected)
        {   //AAA Methodology
            //Arrange

            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.LastName();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Email")]
        [DataRow(new string[] { "abc.xyz@bl.co.in" }, true)]
        [DataRow(new string[] { "abc@%*.com", "Abc.xyz@bl.co.in" }, false)]
        public void Should_Return_Email_Is_Valid_Or_Not(string[] inputs, bool expected)
        {   //AAA Methodology
            //Arrange

            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.Email();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Phone Number")]
        [DataRow(new string[] { "91 9919819801", "91 8545625415" }, true)]
        [DataRow(new string[] { "91 919819801", "91 785425698" }, false)]
        public void Should_Return_phoneNumber_Is_Valid_Or_Not(string[] inputs, bool expected)
        {   //AAA Methodology
            //Arrange

            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.PhoneNumber();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Password")]
        [DataRow(new string[] { "Kjhfld@68", "Ahdyfh@90" }, true)]
        [DataRow(new string[] { "kjhfgdh1", "adfhgsw4" }, false)]
        public void Should_Return_password_Is_Valid_Or_Not(string[] inputs, bool expected)
        {   //AAA Methodology
            //Arrange

            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.Password();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Validate Emails")]
        [DataRow(new string[] { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" }, true)]
        [DataRow(new string[] { "abf@%*.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" }, false)]
        public void Should_Return_Emails_Is_Valid_Or_Not(string[] inputs, bool expected)
        {   //AAA Methodology
            //Arrange


            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                bool actual = regularExpression.ValidateEmails();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
