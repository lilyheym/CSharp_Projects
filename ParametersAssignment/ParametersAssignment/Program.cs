using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things

            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string> { "one", "two", "three" };

            // 4. Instantitate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things

            Employee<int> employeeInteger = new Employee<int>();
            employeeInteger.Things = new List<int> { 1, 2, 3 };

            // 5. Create a loop that prints all of the Things to the console

            foreach(var thing in employeeString.Things)
            {
                Console.WriteLine(thing);
            }

            foreach(var thing in employeeInteger.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();


        }
    }
}
