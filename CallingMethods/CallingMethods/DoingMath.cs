﻿using System;
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
        public int DoingAddition(int userInput)
        {
            
            int methodOutput = userInput + 25;
            return methodOutput;
        }

        // method 2


        public int DoingSubtraction(int userInput)
        {
            
            int methodOutput2 = userInput - 5;
            return methodOutput2;
        }

        // method 3
        public int DoingMultiplication(int userInput)
        {
            
            int methodOutput3 = userInput * 3;   
            return methodOutput3;
        }
    }
}