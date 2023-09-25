﻿namespace Lib.Models
{
    public readonly struct Input
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Input(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
}
