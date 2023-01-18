using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20UserRegistrationMsTest
{
    public class CustomRegularExpressionException: Exception
    {
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
        {
            NULL_INPUT,
            EMPTY_INPUT
        }
        public CustomRegularExpressionException(string msg, ExceptionTypes exceptionTypes) : base(msg)
        {
            this.exceptionTypes = exceptionTypes;
            Console.WriteLine(msg);
        }
    }
}
