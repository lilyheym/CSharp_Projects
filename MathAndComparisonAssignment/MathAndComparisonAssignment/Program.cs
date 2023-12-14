using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate:");
            string hourRatePerson1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string hoursWorkedPerson1 = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate:");
            string hourRatePerson2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string hoursWorkedPerson2 = Console.ReadLine();

            double ratePerson1 = Convert.ToDouble(hourRatePerson1);
            double workedPerson1 = Convert.ToDouble(hoursWorkedPerson1);
            double weeklySalaryPerson1 = ratePerson1 * workedPerson1;
            double annualSalaryPerson1 = weeklySalaryPerson1 * 52;

            double ratePerson2 = Convert.ToDouble(hourRatePerson2);
            double workedPerson2 = Convert.ToDouble(hoursWorkedPerson2);
            double weeklySalaryPerson2 = ratePerson2 * workedPerson2;
            double annualSalaryPerson2 = weeklySalaryPerson2 * 52;
             
            Console.WriteLine("Annual salary of Person 1: " + annualSalaryPerson1);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 2: " + annualSalaryPerson2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.ReadLine();

            bool oneVsTwo = annualSalaryPerson1 > annualSalaryPerson2;

            if(oneVsTwo)
            {
                Console.WriteLine("true");
                Console.Read();
            }
            else
            {
                Console.WriteLine("false");
                Console.ReadLine();
            }



        }
    }
}
