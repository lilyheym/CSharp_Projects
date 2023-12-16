using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenating strings

            string first = "I am the begining.";
            string middle = "\nI am the middle.";
            string end = "\nI am the end.";
            string altogether = first + middle + end;

            Console.WriteLine(altogether);
            Console.ReadLine();

            // Change string to uppercase

            string gonnaChange = "am i talking loud?";
            gonnaChange = gonnaChange.ToUpper();

            Console.WriteLine(gonnaChange);
            Console.ReadLine();

            // Stringbuilder, builds paragraph of text, one sentence at a time

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("I am the first sentence.");
            sb.AppendLine("I am the second sentence.");
            sb.AppendLine("I am the third sentence.");
            sb.AppendLine("I am the fourth sentence.");

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
