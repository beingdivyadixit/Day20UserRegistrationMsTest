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
        [DataRow(new string[] { "Aditya", "Divya" }, "valid")]
        [DataRow(new string[] { "aditya", "divya" }, "Invalid")]
        public void Should_Return_fisrtName_Is_Valid_Or_Not(string [] inputs, string expected)
        {   //AAA Methodology
            //Arrange
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.firstName();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Last Name")]
        [DataRow(new string[] { "Dixit", "Mishra" }, "valid")]
        [DataRow(new string[] { "dixit", "mishra" }, "Invalid")]
        public void Should_Return_lastName_Is_Valid_Or_Not(string [] inputs, string expected)
        {   //AAA Methodology
            //Arrange
           
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.lastName();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Email")]
        [DataRow(new string[] { "abc.xyz@bl.co.in" }, "valid")]
        [DataRow(new string[] { "abc@%*.com", "Abc.xyz@bl.co.in" }, "Invalid")]
        public void Should_Return_Email_Is_Valid_Or_Not(string [] inputs, string expected)
        {   //AAA Methodology
            //Arrange
            
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.email();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Phone Number")]
        [DataRow(new string[] { "91 9919819801", "91 8545625415" }, "valid")]
        [DataRow(new string[] { "91 919819801", "91 785425698" }, "Invalid")]
        public void Should_Return_phoneNumber_Is_Valid_Or_Not(string [] inputs, string expected)
        {   //AAA Methodology
            //Arrange
            
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.phoneNumber();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Password")]
        [DataRow(new string[] { "Kjhfld@68", "Ahdyfh@90" }, "valid")]
        [DataRow(new string[] { "kjhfgdh1", "adfhgsw4" }, "Invalid")]
        public void Should_Return_password_Is_Valid_Or_Not(string [] inputs, string expected)
        {   //AAA Methodology
            //Arrange
           
            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.password();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [TestCategory("Validate Emails")]
        [DataRow(new string[] { "abc.xyz@bridgelabz.co.in", "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc_100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" }, "valid")]
        [DataRow(new string[] { "abf@%*.com", "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" }, "Invalid")]
        public void Should_Return_Emails_Is_Valid_Or_Not(string[] inputs, string expected)
        {   //AAA Methodology
            //Arrange
            

            foreach (string input in inputs)
            {
                RegularExpression regularExpression = new RegularExpression(input);
                //Act
                string actual = regularExpression.validateEmails();

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [DataRow(new string[] {"", "" }, "Message should not be empty")]
        public void Given_Message_Should_Return_Custom_Exception(string[] inputs, string expected)
        {
            try
            {
                //arrange
               
                foreach (string input in inputs)
                {
                    RegularExpression regularExpression = new RegularExpression(input);
                    //Act
                    // string actual = regularExpression.firstName();
                    //string actual = regularExpression.lastName();
                    //string actual = regularExpression.email();
                    //string actual = regularExpression.phoneNumber();
                    //string actual = regularExpression.password();
                    string actual = regularExpression.validateEmails();
                    if (actual != null)
                        Assert.AreEqual(expected, actual);
                }
            }
            catch (CustomRegularExpressionException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

    }
}
