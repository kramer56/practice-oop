using System;
namespace calculator_oop
{
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// /// factory for functions with two arguments: addition, subtraction, division, multiplication, etc.
        /// </summary>
        /// /// <param name="name"> select button </param>
        /// < /// <returns> return completed calculations </returns>
        public static ITwoArgumentsCalculator CreateCalculator(String name)
        {
            switch(name)
            {
                case "summary": return new Additioner();
                case "subtraction": return new Subtrackter();
                case "multiplication": return new Multiplicator();
                case "division": return new Divisioner();
                default: throw new Exception("Неизвестная операция");
            }
          
        }
    }
}
