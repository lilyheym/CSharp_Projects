using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class MathClass
    {
        
        public int MoreMath(int userEntry1)
        {
            int makingInt = Convert.ToInt32(userEntry1);
            int additionResult = makingInt + 5;
            return additionResult;
        }

        public int MoreMath(decimal userEntry1)
        {
            int additionDecimal = Convert.ToInt32(userEntry1);
            int decimalResult = additionDecimal + 5;
            return decimalResult;
        }

        public int MoreMath(string userEntry1)
        {
            int additionStrings = Convert.ToInt32(userEntry1);
            int stringResult = additionStrings + 5;
            return stringResult;
        }
        
    }
}
