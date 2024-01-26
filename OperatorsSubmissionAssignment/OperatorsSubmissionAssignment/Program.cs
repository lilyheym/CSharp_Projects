using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    class Program
    {
        // 3. In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their to their properties. Then compare the two Employee objects using the newly overloaded operators to display the results.
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { ID = 1, FirstName = "Kassidy", LastName = "Yates" };
            Employee employee2 = new Employee { ID = 2, LastName = "Benjamin", FirstName = "Sisko" };

            if(employee1 == employee2)
            {
                Console.WriteLine("The employees have the same ID.");
            }
            else
            {
                Console.WriteLine("The employees don't have the same ID.");
            }
            Console.ReadLine();
        }
    }
}
