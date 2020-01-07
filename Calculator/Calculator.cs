using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return Addition.Sum(a, b);
        }

        public int Divide(int a, int b)
        {
            return Division.Quotient(a, b);
        }
    }
}
