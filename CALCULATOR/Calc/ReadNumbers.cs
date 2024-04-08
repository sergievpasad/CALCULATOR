using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class ReadNumbers:Numbers
    {
        public double ReadNumOne()
        {
            Console.Write("Первое число: ");
            return NumOne = Convert.ToDouble(Console.ReadLine()); ;
        }
        public double ReadNumTwo()
        {
            Console.Write("Второе число: ");
            return NumTwo = Convert.ToDouble(Console.ReadLine());
        }
        public double ReadNum()
        {
            Console.Write("Введите число: ");
            return Num = Convert.ToDouble(Console.ReadLine());
        }
    } 
}
