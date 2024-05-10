using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.	Write a C# program to remove all occurrences of a character from string.
namespace StringAssignment
{
    public class SixthQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";
            char targetChar = 'o';

            string resultString = RemoveCharacter(inputString, targetChar);

            Console.WriteLine("String after removing all occurrences of '" + targetChar + "': " + resultString);
        }

        static string RemoveCharacter(string input, char target)
        {
            return input.Replace(target.ToString(), "");
        }
    }
}
