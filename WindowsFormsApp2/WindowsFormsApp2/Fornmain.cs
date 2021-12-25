using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Fornmain : Form
    {
        public Fornmain()
        {
            InitializeComponent();
        }
        //메소드 ,이벤트 핸들러, 사건처리기, 이벤트처리기
        //버튼을 클릭하면 이 이벤트 실행
        private void btnadd_Click(object sender, EventArgs e)
        {
            

            bool type = chkFloat.Checked; //논리형
            //if (chkFloast.Checked == true)  도 가능
            if(type == true)
            {
                double opr1 = double.Parse(tbxOperand1.Text);//parse는 더블꺼 아래는 인트꺼
                double opr2 = double.Parse(tbxOperand2.Text);
                double sum = opr1 + opr2;
                lblresult.Text = sum.ToString(); //1 > "1" 여기 투스트링은 double클래스의 것 아래는 int꺼
            }
            else
            {
                //int sum = tbxOperand1.Text + tbxOperand2.Text;
                //문자열 > 숫자   숫자 > 문자 (int)사용 못함 
                //class == 자료형  class(변수+메소드) class int에 Parse내장
                //문자열 > 숫자로 바꿔서 opr에 넣음
                //입력 F9누르면 디버깅모드 브레이크 F10누르면 한단계씩
                int opr1 = int.Parse(tbxOperand1.Text);
                int opr2 = int.Parse(tbxOperand2.Text);

                //처리
                int sum = opr1 + opr2;

                //sum은 정수형이라 lbl에 표시하려면 문자열로 바꿔야함
                //출력
                lblresult.Text = sum.ToString(); //1 > "1"
            }
        }
    }
}
