using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathOperations
    {
        // 특수 연산
        public double Inverse(double value)  // 1/x
        {
            return 1 / value;
        }
        public double Square(double value)   // x^2
        {
            return value * value;
        }
        public double SquareRoot(double value) // √x
        {
            return Math.Pow(value, 0.5);
        }
        public double Percent(double value) // value%
        {
            return value / 100;
        }
        public double ReverseSign(double value) // 현재 부호의 반대로 변경
        {
            return value * -1;
        }
    }
}
