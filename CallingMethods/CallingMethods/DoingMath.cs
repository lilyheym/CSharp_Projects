using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class DoingMath
    {
        public DoingMath()
        {

        }
        public static void DoingAddition()
        {
            
            int methodOutput = userInput + 25;
            Console.WriteLine(methodOutput);
            Console.ReadLine();
        }


        public static void DoingSubtraction()
        {
            
            int methodOutput2 = userInput2 - 5;
            Console.WriteLine(methodOutput2);
            Console.ReadLine();
        }
        public static void DoingMultiplication()
        {
            
            int methodOutput3 = userInput3 * 3;
            Console.WriteLine(methodOutput3);
            Console.ReadLine();
        }
    }
}
