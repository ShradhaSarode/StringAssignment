using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	WAP to split string into 2 tokens where string is “HELLO$WORLD”
namespace StringAssignment
{
    public class FirstQ
    {
        static void Main(string[] args)
        {
            string input = "HELLO$WORLD";

            string[] tokens = input.Split('$');

            if (tokens.Length == 2)
            {
                string firstToken = tokens[0];
                string secondToken = tokens[1];

                Console.WriteLine("First token: " + firstToken);
                Console.WriteLine("Second token: " + secondToken);
            }
            else
            {
                Console.WriteLine("Invalid input format. Expected exactly one '$' delimiter.");
            }
        }
    }
}
