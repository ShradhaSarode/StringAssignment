using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    //8.	Write a C# program to toggle case of each character of a string.
    public class EightQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";

            string toggledString = ToggleCase(inputString);

            Console.WriteLine("Original string: " + inputString);
            Console.WriteLine("String after toggling case: " + toggledString);
        }

        static string ToggleCase(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
                else if (char.IsLower(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }

            return new string(charArray);
        }
    }
}
