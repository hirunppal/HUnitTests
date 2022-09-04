using System;

namespace HUnit

{
    public class Calculator
    {
        public int Addnumber(int a, int b)
        {
            return a + b;
        }
        public double AddNumberDouble(double a, double b)
        {
            return a + b;
        }
        public bool IsOddNumber(int a)
        { return a % 2 != 0; }
    }

    
}
