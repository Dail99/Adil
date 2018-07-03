using System;

namespace WindowsFormsApplication1
{
    public class TwoTwoArgumentsFactory
    {
        public static ITwoArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch(calculatorname)
            {
                case "ButtonPlus": return new Plus();
                case "ButtonMin": return new Minus();
                case "ButtonUmn": return new Multi();
                case "ButtonDel": return new Div();
                case "ButtonDegree": return new Degree();
                case "ButtonDegreeFraction": return new DegreeFraction();
                case "ButtonLog": return new Log();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
