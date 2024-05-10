using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.	Write a C# program to count occurrences of a character in given string.
namespace StringAssignment
{
    public class ThirdQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";
            char targetChar = 'o';

            int occurrences = CountOccurrences(inputString, targetChar);

            Console.WriteLine("Occurrences of '" + targetChar + "' in the string: " + occurrences);
        }

        static int CountOccurrences(string input, char target)
        {
            int count = 0;

            foreach (char ch in input)
            {
                if (ch == target)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
