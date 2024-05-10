using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    //4.Write a C# program to trim leading white space characters in a string.
    public class FourthQ
    {
        static void Main(string[] args)
        {
            string inputString = "   Hello, World!";

            string trimmedString = TrimLeadingWhitespace(inputString);

            Console.WriteLine("Original string: '" + inputString + "'");
            Console.WriteLine("String after trimming leading whitespace: '" + trimmedString + "'");
        }

        static string TrimLeadingWhitespace(string input)
        {
            return input.TrimStart();
        }
    }
}
