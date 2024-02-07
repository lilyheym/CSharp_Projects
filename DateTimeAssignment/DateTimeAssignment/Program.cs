using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // print current date and time to console
            DateTime currentDatetime = DateTime.Now;
            Console.WriteLine(currentDatetime);
            // ask user for number
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            // add input number to current time
            if (int.TryParse(input, out int hours))
            {
                DateTime futureDatetime = currentDatetime.AddHours(hours);
                Console.WriteLine("In {0} hours it will be {1}.", hours, futureDatetime);
            }
            else Console.WriteLine("Invalid input, please enter a number.");
            Console.Read();

        }
    }
}
