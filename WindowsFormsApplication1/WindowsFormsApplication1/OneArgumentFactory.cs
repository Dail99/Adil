using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class OneArgumentFactory
    {
        public static OneArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch (calculatorname)
            {
                case "radical": return new Radical();
                case "ButtonSin": return new Sin();
                case "ButtonCos": return new Cos();
                case "ButtonTan": return new Tan();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
