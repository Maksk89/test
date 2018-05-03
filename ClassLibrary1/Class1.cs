using System;
using System.Diagnostics.CodeAnalysis;

namespace ClassLibrary1
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Substract(int a, int b)
        {
            int diff = a - b;
            return diff;
        }

        public int Multiply(int a, int b)
        {
            int product = a * b;
            return product;
        }

        public float Divide(float a, float b)
        {
            float quotient = a / b;
            return quotient;
        }
    }
}