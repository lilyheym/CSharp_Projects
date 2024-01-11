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
        public static int DoingAddition(int userInput)
        {
            
            int methodOutput = userInput + 25;
            Console.WriteLine(methodOutput);
            Console.ReadLine();
            return methodOutput;
        }


        public static int DoingSubtraction(int userInput)
        {
            
            int methodOutput2 = userInput - 5;
            Console.WriteLine(methodOutput2);
            Console.ReadLine();
            return methodOutput2;
        }
        public static int DoingMultiplication(int userInput)
        {
            
            int methodOutput3 = userInput * 3;
            Console.WriteLine(methodOutput3);
            Console.ReadLine();
            return methodOutput3;
        }
    }
}
