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
        [DataRow(new string[] { "Aditya", "Divya" })]
        [DataRow(new string[] { "aditya", "divya" })]
        public void Should_Return_fisrtName_Is_Valid_Or_Not(string[] inputs)
        {   //AAA Methodology
            //Arrange
            try
            {
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.FirstName();

                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch (CustomRegularExpressionException ex)
            {
                Assert.AreEqual("Invalid First Name", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow(new string[] { "Dixit", "Mishra" })]
        [DataRow(new string[] { "dixit", "mishra" })]
        public void Should_Return_lastName_Is_Valid_Or_Not(string[] inputs)
        {   //AAA Methodology
            //Arrange

            try
            {
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.LastName();

                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch (CustomRegularExpressionException ex)
            {
                Assert.AreEqual("Invalid Last Name", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Email")]
        [DataRow(new string[] { "abc.xyz@bl.co.in" })]
        [DataRow(new string[] { "abc@%*.com", "Abc.xyz@bl.co.in" })]
        public void Should_Return_Email_Is_Valid_Or_Not(string[] inputs)
        {   //AAA Methodology
            //Arrange
            try
            {
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.Email();

                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch (CustomRegularExpressionException ex)
            {
                Assert.AreEqual("Invalid Email", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Phone Number")]
        [DataRow(new string[] { "91 9919819801", "91 8545625415" })]
        [DataRow(new string[] { "91 919819801", "91 785425698" })]
        public void Should_Return_phoneNumber_Is_Valid_Or_Not(string[] inputs)
        {   //AAA Methodology
            //Arrange
            try
            {
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.PhoneNumber();

                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch (CustomRegularExpressionException ex)
            {
                Assert.AreEqual("Invalid Phone Number", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Password")]
        [DataRow(new string[] { "Kjhfld@68", "Ahdyfh@90" })]
        [DataRow(new string[] { "kjhfgdh1", "adfhgsw4" })]
        public void Should_Return_password_Is_Valid_Or_Not(string[] inputs)
        {   //AAA Methodology
            //Arrange
            try
            {
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.Password();

                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch (CustomRegularExpressionException ex)
            {
                Assert.AreEqual("Invalid Password", ex.Message);
            }
        }
        [TestMethod]
        [TestCategory("Validate Emails")]
        [DataRow(new string[] { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" })]
        [DataRow(new string[] { "abf@%*.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" })]
        public void Should_Return_Emails_Is_Valid_Or_Not(string[] inputs)
        {   //AAA Methodology
            //Arrange

            try
            {
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    bool actual = regularExpression.ValidateEmails();

                    //Assert
                    Assert.IsTrue(actual);
                }
            }
            catch (CustomRegularExpressionException ex)
            {
                Assert.AreEqual("Invalid Emails", ex.Message);
            }
        }
    }
}
