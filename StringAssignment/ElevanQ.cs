using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    //11.	Write a C# program to reverse order of words in a given string.
    public class ElevanQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello World! This is a test string.";

            string reversedString = ReverseWords(inputString);

            Console.WriteLine("Original string: " + inputString);
            Console.WriteLine("String with words reversed: " + reversedString);
        }

        static string ReverseWords(string input)
        {
            // Split the input string into words
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Reverse the order of words
            Array.Reverse(words);

            // Join the reversed words back into a string
            return string.Join(" ", words);
        }
    }
}
