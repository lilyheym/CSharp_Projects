using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            StarTrek obj = new StarTrek();

            // console requests user input two numbers, one at a time

            Console.WriteLine("Please enter a number:");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number - optional:");
            string forLooping = Console.ReadLine();
            int userInput2;

            // loop because compiler won't accept a null value otherwise

            if (string.IsNullOrEmpty(forLooping))
            {
                userInput2 = 0;
                
            }
            else
            {
                userInput2 = Convert.ToInt32(forLooping);
                
            }
            int operationResult;

            operationResult = obj.Enterprise(userInput1, userInput2);

            Console.WriteLine(operationResult);
            Console.ReadLine();
            
            
        }
    }
}
