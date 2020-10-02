using System;
using System.ComponentModel;

namespace NewCalculator
{
    public class Calculator
    {
        // Her lave man variable til dependencies

        // Property
        public double Accumulator { get; private set; }
        public Calculator()
        {
            Accumulator = 0.0;
        }

        public double Add(double d1, double d2)
        {
            Accumulator = d1 + d2;
            return Accumulator;
        }

        public double Add(double a1)
        {
            Accumulator += a1;
            return Accumulator;
        }
    }
}
