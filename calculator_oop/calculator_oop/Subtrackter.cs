namespace calculator_oop
{
    internal class Subtrackter : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber) 
        { 
            return firstNumber - secondNumber; 
        }
    }
}