using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FornInfo : Form
    {
        public FornInfo()
        {
            InitializeComponent();
        }
        string[] number = new string[5];
        string[] name = new string[5];
        double[] score = new double[5];
        int index = 0;
        //출력할때 같은 타입 변수 여러개 저장하는 법 배열, 리스트 중
        //배열사용씨샵에서는 변수뒤가 아닌 타입앞에 붙힘
        //인스턴스변수
        private void btnnew_Click(object sender, EventArgs e)
        {
            if(index>=5)
            {
                MessageBox.Show("수강인원이 가득찼습니다.");
                return; //메소드 끝 btnnew_click
            }
            //신규입력
            number[index] = tbxnumber.Text;
            name[index] = tbxname.Text;
            score[index] = double.Parse(tbxscore.Text);
            //위에서는 변수뒤가 아니라 타입앞에서 []붙혓는데 여기서는 변수뒤에?

            tbxoutput.Text = $"{number[index]}-{name[index]}-{score[index]}";
            index++;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            //입력된 모든학생 나오게
            //위에 변수 못씀 C언어 지역,전역변수 개념
            //C샵에서는 클래스선언변수 멤버(인스턴스)변수
            //메소드안에는 지역변수 각각 메소드 안에가 먼저임 그 후 멤버변수 찾음
            //namespace안에서는 변수 선언 못함 클래스 안 메소드 안 밖에 안댐
            tbxoutput.Text = "";
            tbxoutput.Text = string.Empty;
            tbxoutput.Clear();
            // 처음 입력한 값 지워지게 셋다 초기화
            for (int i =0; i<index; i++)
            {
                tbxoutput.Text += $"{number[i]}-{name[i]}-{score[i]}";
                tbxoutput.Text += Environment.NewLine;//줄추가 = \n
            }
            
        }
    }
}
