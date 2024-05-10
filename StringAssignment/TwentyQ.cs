using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//20.	Accept email_id from user and check valid or not(should contain @,.)
namespace StringAssignment
{
    public class TwentyQ
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an email address:");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Console.WriteLine("The email address '" + email + "' is valid.");
            }
            else
            {
                Console.WriteLine("The email address '" + email + "' is not valid.");
            }
        }

        static bool IsValidEmail(string email)
        {
            // Define a regular expression pattern for a valid email address
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the given email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
    }
}
