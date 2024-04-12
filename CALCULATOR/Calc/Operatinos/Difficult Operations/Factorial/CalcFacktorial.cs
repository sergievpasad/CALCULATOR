using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class CalcFacktorial:ReadNumbers
    {
        public double CalcFak()
        {
            if (Num > 1)
            {
                Num--;
                return Num * CalcFak();
            }
            return 1;
        }
    }
}
