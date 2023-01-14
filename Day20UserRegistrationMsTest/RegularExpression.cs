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
