using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class ExtractRoot:ReadNumbers
    {
        public void DoExtract()
        {
            ReadNumOne();
            ReadNumTwo();
            PrintRes( Math.Round(Math.Pow(NumOne, 1 / NumTwo), 10));
        }
    }
}
