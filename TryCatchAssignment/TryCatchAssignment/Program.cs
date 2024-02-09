using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // try/catch block
           try
            {
                // ask age
                Console.WriteLine("Please enter your age.");
                int age = int.Parse(Console.ReadLine());
                // display birth year
                if (age <= 0)
                {
                    Console.WriteLine("Age cannot be equal to or less and zero.");
                }
                else
                {
                    int currentYear = DateTime.Now.Year;
                    int userBirthYear = currentYear - age;
                    Console.WriteLine("You were born in {0}.", userBirthYear);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole integer.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please double check your entry and try again.");
            }

            
        }
    }
}
