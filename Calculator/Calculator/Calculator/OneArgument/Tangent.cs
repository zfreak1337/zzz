﻿using System;
namespace Calculator.OneArgument
{
    public class Tangent : IOneCalculator
    {/// <summary>
     /// calculate Tangent function
     /// </summary>
     /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}