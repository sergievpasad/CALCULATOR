using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class ReadKey:ObjectKey
    {
        public string ReadK()
        {
            return Key = Console.ReadLine();
        }
    }
}
