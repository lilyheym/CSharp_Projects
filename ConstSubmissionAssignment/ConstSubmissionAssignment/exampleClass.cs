using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstSubmissionAssignment
{
    // 3. Chain two constructors together
    public class exampleClass
    {
        private int exampleInt;

        public exampleClass(int example)
        {
            exampleInt = example;
        }

        public exampleClass(int example, int example2)
        {
            exampleInt = example + example2;
        }
    }
}
