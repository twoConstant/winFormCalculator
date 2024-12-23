using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class CalculatorForm : Form
    {
        double firstOperand = 0;
        double secondOperand = 0;

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


        // ===== 특수 연산 기능 버튼 이벤트 모음 시작 ===== 
        
        // 1/x 연산
        private void button_multiInverse_Click(object sender, EventArgs e)
        {

        }
        // x^2 연산
        private void button_square_Click(object sender, EventArgs e)
        {

        }
        // 루트 연산
        private void button_root_Click(object sender, EventArgs e)
        {

        }
        // % 연산
        private void button_percent_Click(object sender, EventArgs e)
        {

        }
        // +/- 연산
        private void button_convOper_Click(object sender, EventArgs e)
        {

        }
        // ===== 특수 연산 기능 버튼 이벤트 모음 끝 ===== 


        // ===== 숫자 버튼 클릭 이벤트 모음 시작 ===== 
        private void button_0_Click(object sender, EventArgs e)
        {

        }

        private void button_1_Click(object sender, EventArgs e)
        {

        }

        private void button_2_Click(object sender, EventArgs e)
        {

        }

        private void button_3_Click(object sender, EventArgs e)
        {

        }

        private void button_4_Click(object sender, EventArgs e)
        {

        }

        private void button_5_Click(object sender, EventArgs e)
        {

        }

        private void button_6_Click(object sender, EventArgs e)
        {

        }

        private void button_7_Click(object sender, EventArgs e)
        {

        }

        private void button_8_Click(object sender, EventArgs e)
        {

        }

        private void button_9_Click(object sender, EventArgs e)
        {

        }
        // ===== 숫자 버튼 클릭 이벤트 모음 끝 ===== 


        // ===== 사칙연산 버튼 클릭 이벤트 모음 시작 ===== 
        private void button_plus_Click(object sender, EventArgs e)
        {

        }

        private void button_minus_Click(object sender, EventArgs e)
        {

        }

        private void button_multiply_Click(object sender, EventArgs e)
        {

        }

        private void button_divide_Click(object sender, EventArgs e)
        {

        }
        // ===== 사칙연산 버튼 클릭 이벤트 모음 끝 ===== 


        // ===== 기타 버튼 클릭 이벤트 모음 시작 =====
        // 점 입력
        private void button_dot_Click(object sender, EventArgs e)
        {

        }
        // Clear Entry(직전 입력 지우기) 
        private void button_CE_Click(object sender, EventArgs e)
        {

        }
        // Clear(모두 지우기)
        private void button_C_Click(object sender, EventArgs e)
        {

        }
        // backspace
        private void button_back_Click(object sender, EventArgs e)
        {

        }
        // = 연산
        private void button_equal_Click(object sender, EventArgs e)
        {

        }
        // ===== 기타 버튼 클릭 이벤트 모음 끝 ===== 
    }
}
