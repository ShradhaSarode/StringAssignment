using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//21.	Accept sentence replace each vowel by next consecutive character
namespace StringAssignment
{
    public class TwentyOneQ
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string replacedSentence = ReplaceVowels(sentence);

            Console.WriteLine("Sentence with vowels replaced by next consecutive character:");
            Console.WriteLine(replacedSentence);
        }

        static string ReplaceVowels(string sentence)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] characters = sentence.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (Array.IndexOf(vowels, characters[i]) != -1)
                {
                    characters[i] = GetNextConsecutiveCharacter(characters[i]);
                }
            }

            return new string(characters);
        }

        static char GetNextConsecutiveCharacter(char ch)
        {
            if (ch == 'z')
            {
                return 'a';
            }
            else if (ch == 'Z')
            {
                return 'A';
            }
            else if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))
            {
                return (char)(ch + 1);
            }
            else
            {
                return ch; // Return unchanged character if not a letter
            }
        }
    }
}
