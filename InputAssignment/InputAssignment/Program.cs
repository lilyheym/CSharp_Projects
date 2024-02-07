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
            Console.WriteLine("Please write a number.");
            string inputText = Console.ReadLine();
            File.WriteAllText(@"C:\Users\lilyr\Logs\InpuAssignment.txt", inputText);
            string readInput = File.ReadAllText(@"C:\Users\lilyr\Logs\InpuAssignment.txt");
            Console.WriteLine(readInput);
            Console.Read();
        }
    }
}
