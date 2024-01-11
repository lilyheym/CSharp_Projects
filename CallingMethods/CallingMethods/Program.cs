using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            // prompt user to input number

            Console.WriteLine("Enter a number to do math operations on.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // calling methods

            DoingMath.DoingAddition(userInput);
            DoingMath.DoingSubtraction(userInput);
            DoingMath.DoingMultiplication(userInput);
            
        }
    }
}
