using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // 3. Create another class called employee and have it inherit from the Person class. Give the employee class a property called 'ID' and have it be of data type int
    public class Employee: Person
    {
        public int ID { get; set; }
    }
}
