using System;

namespace calculator_oop
{
    internal class Exp : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)

        {
            return Math.Exp(firstNumber);
        }
    }
}