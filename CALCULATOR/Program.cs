using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class Program
    {
        static void Main(string[] args)
        {          
            string key;
            key = Console.ReadLine();
            switch (key)
            {
                case "+":
                    DoAddition a = new DoAddition();
                    a.PrintRes(a.DoAdd());
                    break;
                case "*":
                    DoMultiplication b = new DoMultiplication();
                    b.PrintRes(b.DoMul());
                    break;
                case "-":
                    DoSubtraction c = new DoSubtraction();
                    c.PrintRes(c.DoSub());
                    break;
                case "/":
                    DoDivision d = new DoDivision();
                    d.PrintRes(d.DoDiv());
                    break;
                case "sqr":
                case "Sqr":
                    DoDegree e = new DoDegree();
                    e.PrintRes(e.DoDeg());
                    break;
                case "sqrt":
                case "Sqrt":
                    ExtractRoot f = new ExtractRoot();
                    f.PrintRes(f.DoExtract());
                    break;
                   
            }
        }
    }
}
