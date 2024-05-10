using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//15.	Write a C# program to find the duplicate words and their number of occurrences in a string
namespace StringAssignment
{
    public class FifteenQ
    {
        static void Main(string[] args)
        {
            string inputString = "Hello world world hello hello world";

            Dictionary<string, int> wordCount = CountDuplicateWords(inputString);

            Console.WriteLine("Duplicate words and their occurrences:");
            foreach (var kvp in wordCount)
            {
                Console.WriteLine("Word: " + kvp.Key + ", Occurrences: " + kvp.Value);
            }
        }

        static Dictionary<string, int> CountDuplicateWords(string input)
        {
            // Define a dictionary to store word counts
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Split the input string into words
            string[] words = Regex.Split(input.ToLower(), @"\W+");

            // Count the occurrences of each word
            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount[word] = 1;
                    }
                }
            }

            // Filter out words with count less than 2 (not duplicates)

           // wordCount = wordCount.FilterByCount(c => c.Value > 1);//error
            return wordCount;
        }
    }
}
