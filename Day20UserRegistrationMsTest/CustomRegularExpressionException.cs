using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day20UserRegistrationMsTest.CustomRegularExpressionException;

namespace Day20UserRegistrationMsTest
{
    public class CustomRegularExpressionException:Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_PHONENUMBER,
            INVALID_PASSWORD,
            INVALID_ALL_EMAILS
        }
        public CustomRegularExpressionException(string msg,ExceptionTypes exceptionTypes) : base(msg)
        {
            this.exceptionTypes = exceptionTypes;
           
           
        }
    }
}
