using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//19.	How do you swap two string variables without using third or temp variable in C#
namespace StringAssignment
{
    public class NineteenQ
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine("Before swapping:");
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);

            // Swap the strings without using a temporary variable
            str1 = str1 + str2;
            str2 = str1.Substring(0, str1.Length - str2.Length);
            str1 = str1.Substring(str2.Length);

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);
        }
    }
}
