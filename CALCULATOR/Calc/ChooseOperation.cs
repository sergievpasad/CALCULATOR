using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULATOR.Calc
{
    class ChooseOperation:ReadKey
    {
        public void ChooseOper()
        {
            switch (Key)
            {
                case "+":
                    DoAddition a = new DoAddition();
                    a.DoAdd();
                    break;
                case "*":
                    DoMultiplication b = new DoMultiplication();
                    b.DoMul();
                    break;
                case "-":
                    DoSubtraction c = new DoSubtraction();
                    c.DoSub();
                    break;
                case "/":
                    DoDivision d = new DoDivision();
                    d.DoDiv();
                    break;
                case "sqr":
                case "Sqr":
                    DoDegree e = new DoDegree();
                    e.DoDeg();
                    break;
                case "sqrt":
                case "Sqrt":
                    ExtractRoot f = new ExtractRoot();
                    f.DoExtract();
                    break;
                case "sin":
                case "Sin":
                    DoSinus g = new DoSinus();
                    g.DoSin();
                    break;
                case "Cos":
                case "cos":
                    DoCosinus h = new DoCosinus();
                    h.DoCos();
                    break;
                case "Tg":
                case "tg":
                    DoTangens Aa = new DoTangens();
                    Aa.DoTan();
                    break;
                case "Ctg":
                case "ctg":
                    DoCotangens Ab = new DoCotangens();
                    Ab.DoCtg();
                    break;
                case "!":
                    DoFactorial Ac = new DoFactorial();
                    Ac.DoFac();
                    break;
                case "Mod":
                case "mod":
                    DoModule Ad = new DoModule();
                    Ad.DoMod();
                    break;
                case "Don":
                case "don":
                    PrintDonate Ae = new PrintDonate();
                    Ae.PrintDon();
                    break;
                case "Gob":
                case "gob":
                    //PR.PrintMen();
                    break;
            }
            ReadK();
            Console.Clear();
        }
    }
}
