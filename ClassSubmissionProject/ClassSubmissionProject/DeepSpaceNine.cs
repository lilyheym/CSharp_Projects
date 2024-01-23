using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionProject
{
    class DeepSpaceNine
    {
        // 1. Create a class with a void method that outputs an integer (dividing the data passed into it by two)
        public void Defiant(int a)
        {
            int result = a / 2;
            Console.WriteLine($"Your number divided by 2 is: {result}");
        }

        // 4. Create a method with output paramaters
        public void Quarks(int input, out int result)
        {
            result = input * 2;
        }

        // 5. Overload the method
        public void Quarks(double input, out double result)
        {
            result = input * 5;
        }

       
    }
}
