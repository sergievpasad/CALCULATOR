using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc{
    class DoDegree:ReadNumbers
    {
        public void DoDeg()
        {
            ReadNumOne();
            ReadNumTwo();
            PrintRes( Math.Round(Math.Pow(NumOne, NumTwo), 10));
        }
    }
}
