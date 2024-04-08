using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoDivision:ReadNumbers
    {
        public void DoDiv()
        {
            ReadNumOne();
            ReadNumTwo();
            PrintRes( Math.Round(NumOne / NumTwo, 10));
            
        }
    }
}
