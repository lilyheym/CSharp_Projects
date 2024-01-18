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
            int additionResult = userEntry1 + 5;
            return additionResult;
        }

        public decimal MoreMath(decimal userEntry2)
        {
            decimal additionDecimal = userEntry2 + 5;
            int decimalResult = Convert.ToInt32(additionDecimal);
            return decimalResult;
        }

        public string MoreMath(string userEntry3)
        {
            int additionStrings = Convert.ToInt32(userEntry3);
            int stringResult = additionStrings + 5;
            string pleaseWork = Convert.ToString(stringResult);
            return pleaseWork;
        }
        
    }
}
