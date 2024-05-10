using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//14.Write a program using Regular Expression to check valid mobile number or not .Use matches method
namespace StringAssignment
{
    public class FourteenQ
    {
        static void Main(string[] args)
        {
            string mobileNumber = "1234567890";

            if (IsValidMobileNumber(mobileNumber))
            {
                Console.WriteLine("The mobile number '" + mobileNumber + "' is valid.");
            }
            else
            {
                Console.WriteLine("The mobile number '" + mobileNumber + "' is not valid.");
            }
        }

        static bool IsValidMobileNumber(string number)
        {
            // Define a regular expression pattern for a valid mobile number
            string pattern = @"^\d{10}$";

            // Use Regex.IsMatch to check if the given number matches the pattern
            return Regex.IsMatch(number, pattern);
        }
        /* ^ asserts the start of the string.
\d{10} matches exactly 10 digits.
$ asserts the end of the string*/
    }
}
