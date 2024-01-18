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
           


            int result1 = obj.MoreMath(10);
            int result2 = obj.MoreMath(7.2m);
            int result3 = obj.MoreMath("32");

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();


           

           

          
            

           

        }
    }
}
