using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class InputParser
    {
        /// 입력 문자열을 숫자로 변환합니다.
        public double ParseInput(string input)
        {
            return double.Parse(input);
        }

        /// 입력된 정수가 유효한지 확인합니다.
        public bool IsValidNumber(string input)
        {
            return int.TryParse(input, out int result); // int만 검사하도록 되어있는데, 다른 데이터 타입도 넣어야 하면 수정
        }

        /// 입력값에 소수점을 추가합니다.
        public string AddDecimalPoint(string input)
        {
            return input + ".";
        }

        /// 소수점이 포함된 숫자 입력의 유효성을 확인합니다.
        public bool IsDecimalValid(string input)
        {
            return double.TryParse(input, out double result); // double만 검사하도록 되어있는데, 다른 데이터 타입도 넣어야 하면 수정
        }
    }
}
