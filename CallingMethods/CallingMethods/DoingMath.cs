using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class DoingMath
    {

        // constructor. idk it's not doing anything just here as a reminder/placeholder
        public DoingMath()
        {

        }
        // method 1
        public static int DoingAddition(int userInput)
        {
            
            int methodOutput = userInput + 25;
            Console.WriteLine(methodOutput);
            Console.ReadLine();
            return methodOutput;
        }

        // method 2


        public static int DoingSubtraction(int userInput)
        {
            
            int methodOutput2 = userInput - 5;
            Console.WriteLine(methodOutput2);
            Console.ReadLine();
            return methodOutput2;
        }

        // method 3
        public static int DoingMultiplication(int userInput)
        {
            
            int methodOutput3 = userInput * 3;
            Console.WriteLine(methodOutput3);
            Console.ReadLine();
            return methodOutput3;
        }
    }
}
