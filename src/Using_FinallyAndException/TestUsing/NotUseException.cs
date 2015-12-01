using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUsing
{
    class NotUseException
    {
        public bool IsInt(string number)
        {
            bool isInt = true;
            try
            {
                Convert.ToInt32(number);
            }
            catch(Exception ex)
            {
                isInt = false;
            }
            return isInt;
        }
        public bool IsIntCorrect(string number)
        {
            int result;
            bool isInt = int.TryParse(number, out result);
            return isInt;
        }
    }
}
