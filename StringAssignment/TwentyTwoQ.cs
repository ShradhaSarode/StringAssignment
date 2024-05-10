using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    public class TwentyTwoQ
    {
        static void Main(string[] args)
        {
            string[] names = { "Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Hannah", "Ivan", "Jane" };

            // Sort the array in descending order
            Array.Sort(names, (x, y) => y.CompareTo(x));

            Console.WriteLine("Names sorted in descending order:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
