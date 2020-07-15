using System;

namespace calculator_oop
{
    internal class sqrt : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)

        {

            if (firstNumber < 0)

            {
                throw new Exception("Х не долженбыть отрицательным");
            }
            
            return Math.Sqrt(firstNumber);
        }
    }
}