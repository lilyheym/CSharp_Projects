using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAsignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One: One-Dimensional array of Strings

            string[] numArray = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            

            // User Input

            Console.WriteLine("Please write something below:");
            string numArrayUser = Console.ReadLine();

            // Loop One

           foreach (string number in numArray)
            {
                numArray = numArray.Select((Y) => { return Y + numArrayUser; }).ToArray();
            }

            // Loop Two

            for ( int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            Console.ReadLine();

            // Part One End
        }
    }
}
