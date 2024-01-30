using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        // 1. Create Enum for days of the week
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            // 4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week" to the console if an error occurs
            try
            {
                // 2. Prompt the user to enter the current day of the week
                Console.WriteLine("Please enter the current day of the week.");
                // 3. Assign the value to a variable of that enum data type you just created
                string currentDay = Console.ReadLine();
                Days parsedDay = (Days)Enum.Parse(typeof(Days), currentDay);
                Console.WriteLine($"You said today is {parsedDay}");
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
            
        }
    }
}
