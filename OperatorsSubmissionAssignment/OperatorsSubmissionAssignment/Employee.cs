using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    // 1. Create an Employee class with Id, FirstName, and LastName properties
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2. In the Employee class, overload the "==" operator so it checks if two employee objects are equal by comparing their ID property. Remember that comparison operators must be done in pairs

        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.ID == employee2.ID;
        }
        public static bool operator!=(Employee employee1, Employee employee2)
        {
            return !(employee1.ID == employee2.ID);
        }
    }
}
