using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public struct MathOperations
    {
        // 특수 연산
        public double Inverse(double value) => 1 / value;

        public double Square(double value) => value * value;

        public double SquareRoot(double value) => Math.Pow(value, 0.5);

        public double Percent(double value) => value / 100;

        public double ReverseSign(double value) => value * (-1);

    }
}
