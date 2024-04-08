using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc{
    class DoDegree:ReadNumbers
    {
        public double DoDeg()
        {
            ReadNumOne();
            ReadNumTwo();
            return Math.Round(Math.Pow(NumOne, NumTwo), 10);
        }
    }
}
