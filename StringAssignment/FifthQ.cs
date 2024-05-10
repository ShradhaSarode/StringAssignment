using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    //5.	Write a C# program to count total number of words in a string. 
    public class FifthQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World! This is a test string.";

            int wordCount = CountWords(inputString);

            Console.WriteLine("Total number of words in the string: " + wordCount);
        }

        static int CountWords(string input)
        {
            // Split the string into words based on whitespace characters
            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Return the count of words
            return words.Length;
        }
    }
}
