using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoCotangens:ReadNumbers
    {
        public void DoCtg()
        {
            ReadNum();
            PrintRes(Math.Round(1 / Math.Tan(Num), 10));
        }
    }
}
