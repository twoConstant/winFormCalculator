using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator;
using Calculator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator
{
    public partial class CalculatorForm : Form
    {
        enum Operators
        {
            None,       // 기본 상태
            Add,        // 더하기
            Subtract,   // 빼기
            Multiply,   // 곱하기
            Divide,     // 나누기
            ClearMemory,
            ReloadMemory,
            MinusMemory,
            StoreMemory,
        }

        Calculators calculators = new Calculators();

        double intNumber = 0;
        double firstOperand = 0;
        double secondOperand = 0;
        double resultNumber = 0;

        Operators currentOperator = Operators.None;
        bool operatorChangeFlag = false;
        bool equalClickFlag = false;

        MathOperations mathOperation = new MathOperations();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        // ===== 메모리 연산 기능 버튼 이벤트 모음 시작 ===== 

        // 메모리 초기화
        private void button_MC_Click(object sender, EventArgs e)
        {

        }

        // 메모리 값 읽기
        private void button_MR_Click(object sender, EventArgs e)
        {

        }

        // 메모리 값 더하기
        private void button_MPlus_Click(object sender, EventArgs e)
        {

        }

        // 메모리 값 빼기
        private void button_MMinus_Click(object sender, EventArgs e)
        {

        }

        // 메모리 값 저장 
        private void button_MS_Click(object sender, EventArgs e)
        {

        }

        // 메모리 리스트 조회
        private void button_Mv_Click(object sender, EventArgs e)
        {

        }
        // ===== 메모리 연산 기능 버튼 이벤트 모음 끝 ===== 


        // ===== 사칙연산 버튼 클릭 이벤트 모음 시작 ===== 
        #region
        private void button_plus_Click(object sender, EventArgs e)
        {
            label_subDisplay.Text = calculators.GetLatestFormula(label_display.Text, " + ");
            label_display.Text = calculators.GetCurrentDouble();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            label_subDisplay.Text = calculators.GetLatestFormula(label_display.Text, " - ");
            label_display.Text = calculators.GetCurrentDouble();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            label_subDisplay.Text = calculators.GetLatestFormula(label_display.Text, " × ");
            label_display.Text = calculators.GetCurrentDouble();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            label_subDisplay.Text = calculators.GetLatestFormula(label_display.Text, " ÷ ");
            label_display.Text = calculators.GetCurrentDouble();
        }
        // ===== 사칙연산 버튼 클릭 이벤트 모음 끝 ===== 
        #endregion

        // ===== 특수 연산 기능 버튼 이벤트 모음 시작 ===== 

        // 1/x 연산
        private void button_multiInverse_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(label_display.Text);

            resultNumber = mathOperation.Inverse(firstOperand);
            printResult(resultNumber);
        }
        // x^2 연산
        private void button_square_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(label_display.Text);

            resultNumber = mathOperation.Square(firstOperand);
            printResult(resultNumber);
        }
        // 루트 연산
        private void button_root_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(label_display.Text);

            resultNumber = mathOperation.SquareRoot(firstOperand);
            printResult(resultNumber);
        }
        // % 연산
        private void button_percent_Click(object sender, EventArgs e)
        {
            double percentOperand = double.Parse(label_display.Text);
            resultNumber = mathOperation.PercentMultiplyDivide(percentOperand);
            printResult(resultNumber);
        }
        // +/- 연산
        private void button_convOper_Click(object sender, EventArgs e)
        {
            firstOperand = double.Parse(label_display.Text);

            resultNumber = mathOperation.ReverseSign(firstOperand);
            printResult(resultNumber);
        }
        // ===== 특수 연산 기능 버튼 이벤트 모음 끝 ===== 


        // ===== 숫자 버튼 클릭 이벤트 모음 시작 ===== 
        #region

        private void button_0_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("0");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            operatorCheckAndCast("9");
        }
        // ===== 숫자 버튼 클릭 이벤트 모음 끝 ===== 
        #endregion


        // ===== 기타 버튼 클릭 이벤트 모음 시작 =====
        // 점 입력
        private void button_dot_Click(object sender, EventArgs e)
        {

        }
        // Clear Entry(직전 입력 지우기) 
        private void button_CE_Click(object sender, EventArgs e)
        {
            label_display.Text = "0";
        }
        // Clear(모두 지우기)
        private void button_C_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            label_display.Text = "0";
            subDisplayPrint("C");

            operatorChangeFlag = false;
            equalClickFlag = false;

        }
        // backspace
        private void button_back_Click(object sender, EventArgs e)
        {
            string userCurrentInput = label_display.Text;

            if (string.IsNullOrEmpty(userCurrentInput) || userCurrentInput == "0")
            {
                return;
            }

            userCurrentInput = userCurrentInput.Substring(0, userCurrentInput.Length - 1);

            label_display.Text = string.IsNullOrEmpty(userCurrentInput) ? "0" : userCurrentInput;

        }

        // ===== 기타 버튼 클릭 이벤트 모음 끝 ===== 
        private void button_equal_Click(object sender, EventArgs e)
        {
            if (equalClickFlag == false)
            {
                secondOperand = double.Parse(label_display.Text);
                subDisplayPrint(secondOperand.ToString());
                subDisplayPrint(" = ");
            }

            equalClickFlag = true;

            switch (currentOperator)
            {
                case Operators.Add:
                    //resultNumber = mathOperation.Add(firstOperand, secondOperand);
                    printResult(resultNumber);
                    break;
                case Operators.Subtract:
                    //resultNumber = mathOperation.Subtract(firstOperand, secondOperand);
                    printResult(resultNumber);
                    break;
                case Operators.Multiply:
                    //resultNumber = mathOperation.Multiply(firstOperand, secondOperand);
                    printResult(resultNumber);
                    break;
                case Operators.Divide:
                    if (secondOperand == 0)
                    {
                        label_display.Text = "0으로 나눌 수 없습니다.";
                    }
                    else
                    {
                        //resultNumber = mathOperation.Divide(firstOperand, secondOperand);
                        printResult(resultNumber);
                    }
                    break;
            }

            currentOperator = Operators.None;

        }


        // 숫자 입력 시 연산자 확인 및 형변환
        void operatorCheckAndCast(string inputStrNum)
        {
            if (operatorChangeFlag == true)
            {
                label_display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = label_display.Text = equalClickFlag ? inputStrNum : label_display.Text + inputStrNum;

            intNumber = double.Parse(strNumber);
            label_display.Text = intNumber.ToString();
        }

        // 결과 창
        void printResult(double resultNum)
        {
            firstOperand = resultNum;
            label_display.Text = resultNum.ToString();
        }

        // 상단 연산 기록 화면
        void subDisplayPrint(string subDisplayInput)
        {
            if (subDisplayInput.Equals("C"))
            {
                label_subDisplay.Text = "";
            }
            else
            {
                label_subDisplay.Text += subDisplayInput;
            }
        }
    }
}
