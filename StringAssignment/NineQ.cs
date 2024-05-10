using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9.	Write a C# program to count total number of vowels and consonants in a string.
namespace StringAssignment
{
    public class NineQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";

            int vowelCount, consonantCount;
            CountVowelsAndConsonants(inputString, out vowelCount, out consonantCount);

            Console.WriteLine("Total number of vowels: " + vowelCount);
            Console.WriteLine("Total number of consonants: " + consonantCount);
        }

        static void CountVowelsAndConsonants(string input, out int vowelCount, out int consonantCount)
        {
            vowelCount = 0;
            consonantCount = 0;

            input = input.ToLower(); // Convert the input string to lowercase to simplify vowel checking

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
        }
    }
}
