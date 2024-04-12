using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoTangens:ReadNumbers
    {
        public void DoTan()
        {
            ReadNum();
            PrintRes(Math.Round(Math.Tan(Num), 10));
        }
    }
}
