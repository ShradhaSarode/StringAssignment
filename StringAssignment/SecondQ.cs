using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Write a C# program to find first occurrence of a character in a given string
namespace StringAssignment
{
    public class SecondQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";
            char targetChar = 'o';

            int firstOccurrenceIndex = FindFirstOccurrence(inputString, targetChar);

            if (firstOccurrenceIndex != -1)
            {
                Console.WriteLine("First occurrence of '" + targetChar + "' is at index: " + firstOccurrenceIndex);
            }
            else
            {
                Console.WriteLine("Character '" + targetChar + "' not found in the string.");
            }
        }

        static int FindFirstOccurrence(string input, char target)
        {
            return input.IndexOf(target);
        }
    }
}
