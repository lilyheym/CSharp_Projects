using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
       static void Main(string[] args)
        {
            MathClass obj = new MathClass();
            Console.WriteLine("Please enter a whole positive number.");

            // int entry

            int userEntry1 = Convert.ToInt32(Console.ReadLine());
            int result1;
            int result2;
            int result3;


            result1 = obj.MoreMath(userEntry1);
            result2 = obj.MoreMath(userEntry1);
            result3 = obj.MoreMath(userEntry1);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();


           

           

          
            

           

        }
    }
}
