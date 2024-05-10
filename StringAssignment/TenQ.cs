using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10.	Write a C# program to find reverse of a string.
namespace StringAssignment
{
    public class TenQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";

            string reversedString = ReverseString(inputString);

            Console.WriteLine("Original string: " + inputString);
            Console.WriteLine("Reversed string: " + reversedString);
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
