using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    //12.Write a C# program to find highest frequency character in a string.
    public class TwelveQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello, World!";

            char highestFrequencyChar = FindHighestFrequencyCharacter(inputString);

            Console.WriteLine("String: " + inputString);
            Console.WriteLine("Highest frequency character: " + highestFrequencyChar);
        }

        static char FindHighestFrequencyCharacter(string input)
        {
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            // Count frequency of each character
            foreach (char ch in input)
            {
                if (char.IsLetter(ch)) // Consider only letters
                {
                    if (frequencyMap.ContainsKey(ch))
                    {
                        frequencyMap[ch]++;
                    }
                    else
                    {
                        frequencyMap[ch] = 1;
                    }
                }
            }

            // Find character with highest frequency
            char highestFrequencyChar = '\0';
            int maxFrequency = 0;
            foreach (var kvp in frequencyMap)
            {
                if (kvp.Value > maxFrequency)
                {
                    highestFrequencyChar = kvp.Key;
                    maxFrequency = kvp.Value;
                }
            }

            return highestFrequencyChar;
        }
    }
}
