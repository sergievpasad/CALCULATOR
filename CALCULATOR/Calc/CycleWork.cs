using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class CycleWork:ChooseOperation
    {
        public void CycWork()
        {
            ReadK();
            while (Key!="end"||Key!="End")
            {
                ChooseOper();
            }
        }
    }
}
