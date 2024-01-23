using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Inside of the Main method, instatntiate and initialize an Employee object with a first name of 'Sample and a last name of 'Student' 

            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                ID = 123  // Example ID
            };

            // 5. Call the superclass method SayName() on the Employee object

            employee.SayName();
            Console.ReadLine();
        }
    }
}
