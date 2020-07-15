namespace calculator_oop
{
    internal class Multiplicator : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber,double secondNumber)

        {
            return firstNumber * secondNumber;
        }
    }
}