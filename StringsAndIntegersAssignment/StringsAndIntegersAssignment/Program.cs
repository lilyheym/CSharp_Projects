using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumberFour = new List<int> { 1, 45, 38, 92, 90, 4, 76, 84, 33, 11, 32, 470, 857 };

            Console.WriteLine("Please enter a number.");
            int bill = Convert.ToInt32(Console.ReadLine());

            foreach (int frank in listNumberFour)
            {
                int wanda = frank / bill;
                Console.WriteLine(wanda);
            }
            Console.ReadLine();
        }
    }
}
