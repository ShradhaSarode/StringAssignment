using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13.	Write a C# program to find total number of alphabets, digits or special character in a string.
namespace StringAssignment
{
    public class ThirteenQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World! 123";

            int alphabetCount, digitCount, specialCharCount;
            CountCharacters(inputString, out alphabetCount, out digitCount, out specialCharCount);

            Console.WriteLine("String: " + inputString);
            Console.WriteLine("Total number of alphabets: " + alphabetCount);
            Console.WriteLine("Total number of digits: " + digitCount);
            Console.WriteLine("Total number of special characters: " + specialCharCount);
        }

        static void CountCharacters(string input, out int alphabetCount, out int digitCount, out int specialCharCount)
        {
            alphabetCount = 0;
            digitCount = 0;
            specialCharCount = 0;

            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(ch))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }
        }
    }
}
