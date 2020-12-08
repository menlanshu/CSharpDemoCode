using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestDemoLibrary
{
    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Substract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            return y == 0 ? 0 : x / y;
        }
    }
}
