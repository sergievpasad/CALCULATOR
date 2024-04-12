using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoModule:ReadNumbers
    {
        public void DoMod()
        {
            ReadNum();
            if(Num<0)
            {
                Num *= -1;
            }
            PrintRes(Math.Round(Num, 10));
        }
    }
}
