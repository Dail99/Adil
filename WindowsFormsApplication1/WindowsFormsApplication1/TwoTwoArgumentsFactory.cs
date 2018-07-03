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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
