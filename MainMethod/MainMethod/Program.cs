using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
       public void Main(string[] args)
        {
            MathClass obj = new MathClass();
            Console.WriteLine("Please enter a whole positive number.");

            // int entry

            int userEntry1 = Convert.ToInt32(Console.ReadLine());
            int result1;

            result1 = obj.MoreMath(userEntry1);
            Console.WriteLine(result1);
            Console.ReadLine();

            // decimal entry

            decimal userEntry2 = Convert.ToDecimal(Console.ReadLine());
            int result2;

            result2 = (int)obj.MoreMath(userEntry2);
            Console.WriteLine(result2);
            Console.ReadLine();

            // string entry

            string userEntry3 = Console.ReadLine();
            int result3;

            result3 = Convert.ToInt32(obj.MoreMath(userEntry3));
            Console.WriteLine(result3);
            Console.ReadLine();

        }
    }
}
