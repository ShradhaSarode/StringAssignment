using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    //7.	Write a C# program to trim trailing white space characters in a string
    public class SevenQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!   ";

            string trimmedString = TrimTrailingWhitespace(inputString);

            Console.WriteLine("Original string: '" + inputString + "'");
            Console.WriteLine("String after trimming trailing whitespace: '" + trimmedString + "'");
        }

        static string TrimTrailingWhitespace(string input)
        {
            return input.TrimEnd();
        }
    }
}
