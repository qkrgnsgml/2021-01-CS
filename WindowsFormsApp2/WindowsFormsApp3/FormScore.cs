using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormScore : Form
    {
        public FormScore()
        {
            InitializeComponent();
        }
        //이벤트 핸들러, 처리기 (메소드)
        private void btncal_Click(object sender, EventArgs e)
        {
            //과목점수 1가져오고 2계산하고 3출력
            double kor = double.Parse(tbxkor.Text);
            double eng = double.Parse(tbxeng.Text);
            double mat = double.Parse(tbxmat.Text);

            double sum = kor + eng + mat;
            double avg = sum / 3;

            lblavg.Text = avg.ToString("F3");
            lblsum.Text = sum.ToString("0.000");

            if(avg <60)
            { //부ㅡㄹ합격
                lblresult.Text = "불합격(F)";
            }
            else
            {//합격
                lblresult.Text = "합격";
                if(avg>=90)
                {
                    lblresult.Text += "(A)";
                }    
                else if(avg>=80)
                {
                    lblresult.Text += "(B)";
                }
                else if (avg >= 70)
                {
                    lblresult.Text += "(C)";
                }
                else
                {
                    lblresult.Text += "(D)";
                }
            }
        }
    }
}
