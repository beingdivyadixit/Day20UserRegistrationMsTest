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
            if((Regex.IsMatch(inputs, patternFirstName)))
            {
                return true;
            }
            else
            {
                throw new CustomRegularExpressionException("Invalid First Name", CustomRegularExpressionException.ExceptionTypes.INVALID_FIRST_NAME);
            }
        }
        //Created last Name method-UC2
        public bool LastName()
        {
            if ((Regex.IsMatch(inputs, patternLastName)))
            {
                return true;
            }
            else
            {
                throw new CustomRegularExpressionException("Invalid Last Name", CustomRegularExpressionException.ExceptionTypes.INVALID_LAST_NAME);
            }
        
        }
        //Created email method-UC3
        public bool Email()
        {
            if ((Regex.IsMatch(inputs, patternEmail)))
            {
                return true;
            }
            else
            {
                throw new CustomRegularExpressionException("Invalid Email", CustomRegularExpressionException.ExceptionTypes.INVALID_EMAIL);
            }
        }
        //Created phone number method
        public bool PhoneNumber()
        {
            if ((Regex.IsMatch(inputs, patternPhoneNumber)))
            {
                return true;
            }
            else
            {
                throw new CustomRegularExpressionException("Invalid Phone Number", CustomRegularExpressionException.ExceptionTypes.INVALID_PHONENUMBER);
            }
        }
        //Created password method
        public bool Password()
        {
            if ((Regex.IsMatch(inputs, patternPassword)))
            {
                return true;
            }
            else
            {
                throw new CustomRegularExpressionException("Invalid Password",CustomRegularExpressionException.ExceptionTypes.INVALID_PASSWORD);
            }

        }
        //Created method clear all samples of emails-UC9
        public bool ValidateEmails()
        {
            if ((Regex.IsMatch(inputs, patternValidateEmails)))
            {
                return true;
            }
            else
            {
                throw new CustomRegularExpressionException("Invalid Emails", CustomRegularExpressionException.ExceptionTypes.INVALID_ALL_EMAILS);
            }

        }
    }
}
