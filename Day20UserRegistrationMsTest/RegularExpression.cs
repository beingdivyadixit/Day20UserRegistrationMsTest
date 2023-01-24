using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day20UserRegistrationMsTest
{
     public class RegularExpression
     {
        public string inputs;
        public string patternFirstName = "^[A-Z]{1}[a-z]{2,}$";
        public string patternLastName = "^[A-Z]{1}[a-z]{2,}$";
        public string patternEmail = "^[a-z]{3}.[a-z]{2,}@[a-z]{2}.[a-z]{2}.[a-z]{2}$";
        public string patternPhoneNumber = "^[0-9]{2}[ ][0-9]{10}$";
        public string patternPassword = "^[A-Z]{1}[a-z]{4,}(@|#|$|&){1}[0-9]{1,}$";
        public string patternValidateEmails = "^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$";
        public RegularExpression()
        {

        }
        public RegularExpression(string inputs)
        {
            this.inputs = inputs;
        }
        //Created first Name method
        public bool FirstName()
        {
            return (Regex.IsMatch(inputs, patternFirstName));
        }
        //Created last Name method-UC2
        public bool LastName()
        {
            return (Regex.IsMatch(inputs, patternLastName));
        }
        //Created email method-UC3
        public bool Email()
        {
            return (Regex.IsMatch(inputs, patternEmail));
        }
        //Created phone number method
        public bool PhoneNumber()
        {
            return (Regex.IsMatch(inputs, patternPhoneNumber));
        }
        //Created password method
        public bool Password()
        {
            return (Regex.IsMatch(inputs, patternPassword));

        }
        //Created method clear all samples of emails-UC9
        public bool ValidateEmails()
        {
            return (Regex.IsMatch(inputs, patternValidateEmails));

        }
    }
}
