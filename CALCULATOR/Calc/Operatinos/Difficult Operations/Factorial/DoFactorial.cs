using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoFactorial:CalcFacktorial
    {
        public void DoFac()
        {
            ReadNum();
            Num++;
            PrintRes(Math.Round(CalcFak(), 10));
        }
    }
}
