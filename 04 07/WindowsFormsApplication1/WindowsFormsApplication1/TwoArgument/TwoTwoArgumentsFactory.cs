﻿using System;

namespace MainCalculator
{
    public class TwoTwoArgumentsFactory
    {
        public static ITwoArgumentCalculator CreateCalculator(string calculatorname)
        {
            switch(calculatorname)
            {
                case "plusSolution": return new Plus();
                case "minSolution": return new Minus();
                case "multiSolution": return new Multi();
                case "delSolution": return new Div();
                case "degreeSolution": return new Degree();
                case "degreeFraction": return new DegreeFraction();
                case "logSolution": return new Log();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
