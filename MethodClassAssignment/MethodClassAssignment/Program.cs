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

            int a = 1;
            int b = 6;

            int result = obj.Tuvok(a, b);

            int result2 = obj.Tuvok(7, 5);
        }
    }
}
