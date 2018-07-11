﻿using System;

namespace Calculator.OneArgument
{
    public class Arctangent: IOoneCalculator
    {/// <summary>
        /// calculate Arctangent function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
