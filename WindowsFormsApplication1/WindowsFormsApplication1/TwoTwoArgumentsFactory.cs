using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TwoTwoArgumentsFactory
    {
        public static ITwoArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch(calculatorname)
            {
                case "Plus": return new Plus();
                case "Minus": return new Minus();
                case "Multi": return new Multi();
                case "Div": return new Div();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
