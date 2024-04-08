using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoAddition:ReadNumbers
    {
        public void DoAdd()
        {
            ReadNumOne();
            ReadNumTwo();
            PrintRes(Math.Round( NumOne + NumTwo,10));
        }
    }
}
