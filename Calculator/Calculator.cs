using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    static class Calculator
    {
        public static double Sum (double a, double b)
        {
            return a + b;
        }

        public static double Subtract (double a, double b)
        {
            return a - b;
        }

        public static double Multiply (double a, double b)
        {
            return a * b;
        }

        public static double Divide (double a, double b)
        {
            return a / b;
        }

        public static double Power (double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double Root (double a, double b)
        {
            double c = 1 / b;
            return Math.Pow(a, c);
        }

    }
}
