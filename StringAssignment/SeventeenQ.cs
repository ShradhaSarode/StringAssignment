using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//17.	Write a C# program to reverse a given string with preserving the position of spaces
namespace StringAssignment
{
    public class SeventeenQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello World!";

            string reversedString = ReverseStringWithSpaces(inputString);

            Console.WriteLine("Original string: " + inputString);
            Console.WriteLine("Reversed string with preserved spaces: " + reversedString);
        }

        static string ReverseStringWithSpaces(string input)
        {
            string[] words = input.Split(' ');

            StringBuilder reversedString = new StringBuilder();

            foreach (string word in words)
            {
                char[] characters = word.ToCharArray();
                Array.Reverse(characters);
                reversedString.Append(characters);
                reversedString.Append(' '); // Add space after each word
            }

            return reversedString.ToString().TrimEnd(); // Remove trailing space
        }
    }
}
