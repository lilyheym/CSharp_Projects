using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method, create a list of at least 10 employees. At least two employees should have the same first name "Joe"

            List<Employee> employeeList = new List<Employee>
            {
                new Employee { ID = 1, FirstName = "Hannibal", LastName = "Lecter" },
                new Employee { ID = 2, FirstName = "Will", LastName = "Graham"},
                new Employee { ID = 3, FirstName = "Jack", LastName = "Crawford"},
                new Employee { ID = 4, FirstName = "Freddie", LastName = "Lounds"},
                new Employee { ID = 5, FirstName = "Alana", LastName = "Bloom"},
                new Employee { ID = 6, FirstName = "Joe", LastName = "Smith"},
                new Employee { ID = 7, FirstName = "Abigail", LastName = "Hobbs"},
                new Employee { ID = 8, FirstName = "Bedelia", LastName = "Du Maurier"},
                new Employee { ID = 9, FirstName = "Beverly", LastName = "Katz"},
                new Employee { ID = 10, FirstName = "Joe", LastName = "Bob"}
            };

            // 3. Using a foreach loop, create a new list of all employees with the first name "Joe". In your comparison statement, remember to reference the property of the object you are checking

            List<Employee> listOfJoes = new List<Employee>();

            foreach(Employee employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    listOfJoes.Add(employee);
                }
            }
            Console.WriteLine("Employees with the First Name 'Joe':");

            foreach(Employee joe in listOfJoes)
            {
                Console.WriteLine($"ID: {joe.ID}, First Name: {joe.FirstName}, Last Name: {joe.LastName}");
            }
            Console.ReadLine();

            // 4. Perform the same action again, but this time with a lambda experssion

            List<Employee> joeList = employeeList.FindAll(x => x.FirstName == "Joe");

            Console.WriteLine("Employees with the First Name 'Joe' but make it Lambda:");

            foreach(Employee joe in joeList)
            {
                Console.WriteLine($"ID: {joe.ID}, First Name: {joe.FirstName}, Last Name: {joe.LastName}");
            }
            Console.ReadLine();

            // 5. Using a lambda expression, make a list of all employees with an ID greater than 5

            List<Employee> joesOfFive = employeeList.FindAll(x => x.ID > 5);

            Console.WriteLine("Employees with an ID greater than 5");

            foreach (Employee employee in joesOfFive)
            {
                Console.WriteLine($"ID: {employee.ID}, First Name: {employee.FirstName}, Last Name: {employee.LastName}");
            }
            Console.ReadLine();
        }
    }
}
