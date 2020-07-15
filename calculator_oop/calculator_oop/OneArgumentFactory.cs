using System;
namespace calculator_oop
{
    class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(String name)
        {
            switch (name)
            {
                case "sqrt": return new sqrt();
                case "exp": return new Exp();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
