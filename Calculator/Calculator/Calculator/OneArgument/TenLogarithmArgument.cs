﻿using System;
namespace Calculator.OneArgument
{
    public class TenLogarithmArgument : IOoneCalculator
    {
        /// <summary>
        /// calculate TenLogarithmArgument function
        /// </summary>
        /// <param name="firstArgument"></param>
        public double Calculate(double firstArgument)
        {
            return Math.Log(10, firstArgument);

        }
    }
}

