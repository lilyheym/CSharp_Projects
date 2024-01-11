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
            int result;
            int result2;
            int result3;

            // calling methods

            result = DoingMath.DoingAddition(userInput);
            result2 = DoingMath.DoingSubtraction(userInput);
            result3 = DoingMath.DoingMultiplication(userInput);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
            
        }
    }
}
