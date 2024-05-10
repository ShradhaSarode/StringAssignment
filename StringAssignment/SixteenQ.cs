using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//16.	Write a C# program to check whether two strings are anagram or not?
namespace StringAssignment
{
    public class SixteenQ
    {
        static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "silent";

            if (AreAnagrams(str1, str2))
            {
                Console.WriteLine("'" + str1 + "' and '" + str2 + "' are anagrams.");
            }
            else
            {
                Console.WriteLine("'" + str1 + "' and '" + str2 + "' are not anagrams.");
            }
        }

        static bool AreAnagrams(string str1, string str2)
        {
            // Check if the lengths of the strings are equal
            if (str1.Length != str2.Length)
            {
                return false;
            }

            // Sort the characters of both strings
            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // Compare sorted strings
            string sortedStr1 = new string(charArray1);
            string sortedStr2 = new string(charArray2);

            return sortedStr1.Equals(sortedStr2);
        }
    }
}
