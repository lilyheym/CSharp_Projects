using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Note to self: see how much easier this is to just put the assignment descriptors in the actual file instead of flipping back and forth?
namespace ClassSubmissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. instantiate the class
            DeepSpaceNine obj = new DeepSpaceNine();

            // 3. Have the user enter a number, call the method, and display the output
            Console.WriteLine("Please enter a number to be divided by two.");

            if(int.TryParse(Console.ReadLine(), out int userInput))
            {
                obj.Defiant(userInput);
            }
            else
            {
                Console.WriteLine("Sorry, input needs to be an integer.");
            }
            Console.ReadLine();

            

            
        }
    }
}
