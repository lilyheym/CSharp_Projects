using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pachage Express. Please follow the instructions below.");
            Console.ReadLine();

            // Weight

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to ship via Pavkage Express. Have a good day.");
                Console.ReadLine();
                return;

            }

            // Width

            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            // Height

            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            // Length

            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            // Adding dimensions together

            if (packageHeight + packageLength + packageWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Calculating estimated total

            int dimesnsionTotal = (packageHeight * packageLength * packageWidth * packageWeight) / 100;

            // Displaying estimated total

            Console.WriteLine("Your estimated total for shipping this package is: " + dimesnsionTotal);
            Console.WriteLine("Thank you!");
            Console.ReadLine();



        }
    }
}
