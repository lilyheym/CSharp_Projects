using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Voyager obj = new Voyager();

            // call by parameter name

            obj.Tuvok(a:5, b:7);

            // call by passing in numbers

            obj.Tuvok(4, 10);

            Console.ReadLine();
        }
    }
}
