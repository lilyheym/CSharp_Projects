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
            Console.WriteLine("Enter a number to do math operations on.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            DoingMath.DoingAddition();
            DoingMath.DoingSubtraction();
            DoingMath.DoingMultiplication();
            
        }
    }
}
