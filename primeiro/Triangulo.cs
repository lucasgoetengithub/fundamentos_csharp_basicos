﻿using System;

namespace Primeiro {
    class Triangulo {

        public Double A;
        public Double B;
        public Double C;

        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
