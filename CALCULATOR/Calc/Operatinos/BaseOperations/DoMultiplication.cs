﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class DoMultiplication:ReadNumbers
    {
        public void DoMul()
        {
            ReadNumOne();
            ReadNumTwo();
            PrintRes( Math.Round(NumOne * NumTwo,10));
        }
    }
}
