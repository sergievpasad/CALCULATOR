using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoCosinus:ReadNumbers
    {
        public void DoCos()
        {
            ReadNum();
            PrintRes(Math.Round(Math.Cos(Num), 10));
        }
    }
}
