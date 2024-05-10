using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//18.	WAP to find longest word in the given sentence
namespace StringAssignment
{
    public class EighteenQ
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";

            string longestWord = FindLongestWord(sentence);

            Console.WriteLine("Longest word in the sentence: " + longestWord);
        }

        static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = string.Empty;

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }
    }
}
