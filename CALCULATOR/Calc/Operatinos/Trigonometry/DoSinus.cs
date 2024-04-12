using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoSinus : ReadNumbers
    {
        public void DoSin()
        {
            ReadNum();
            PrintRes(Math.Round(Math.Sin(Num), 10));
        }
    }
}
