using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompts user for number
            Console.WriteLine("Please write a number.");
            string inputText = Console.ReadLine();
            // adds input to file
            File.WriteAllText(@"C:\Users\lilyr\Logs\InpuAssignment.txt", inputText);
            string readInput = File.ReadAllText(@"C:\Users\lilyr\Logs\InpuAssignment.txt");
            // prints file back to conole
            Console.WriteLine(readInput);
            Console.Read();
        }
    }
}
