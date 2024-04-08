using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoAddition:ReadNumbers
    {
        public double DoAdd()
        {
            ReadNumOne();
            ReadNumTwo();
            return NumOne + NumTwo;
        }
    }
}
