using System;

namespace Calculator
{
    public class Calculator
    {
        public static int Add2(int a, int b)
        {
            return a + b;
        }

        public static int Div(int a, int b)
        {
            if (b != 0)
            {
                return (a/b);
            }
            else
            {
                throw new DivideByZeroException("Div by ZERO ERROR");
            }
        }
    }
}