using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day20UserRegistrationMsTest
{
     public class RegularExpression
     {        //Created first Name method
        public string firstName(string inputs)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
             return TestPattern(pattern, inputs);
        }
        //Created last Name method-UC2
        public string lastName(string inputs)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestPattern(pattern, inputs);
        }
        //Created email method-UC3
        public string email(string inputs)
        {
            string pattern = "^[a-z]{3}.[a-z]{2,}@[a-z]{2}.[a-z]{2}.[a-z]{2}$";
            return TestPattern(pattern, inputs);
        }
        //Created phone number method
        public string phoneNumber(string inputs)
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            return TestPattern(pattern, inputs);
        }
        //Created password method
        public string password(string inputs)
        {
            string pattern = "^[A-Z]{1}[a-z]{7,}$";
            return TestPattern(pattern, inputs);
        }
        //Created Test pattern method
        public  string TestPattern(string pattern, string inputs)
        {
           
                if (Regex.IsMatch(inputs, pattern))
                {
                    return "valid";
                }
                else
                {
                    return "Invalid";
                }
      
          
        }
     }
}
