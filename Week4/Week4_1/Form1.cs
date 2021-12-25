using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int scores_index = 0; //전역변수,인스턴스변수
        double[] scores = new double[10]; //배열, 고정길이
        private void btnInput_Click(object sender, EventArgs e)
        {
            //배열 길이 체크
            if (scores_index > scores.Length)//모든 배열의 속성 Length
            {
                lblResult.Text = "더이상 입력불가";
                return;
            }
            //점수 가져와서 변환,
            //double score = double.Parse(tbxScore.Text); 
            //double score;
            // bool isConv = double.TryParse(tbxScore.Text, out score);
            //TryParse 라는 함수는 잘되면 True 안되면 false 그리고 out score로 보냄
            bool isConv = double.TryParse(tbxScore.Text, out double score);//요즘 버전 가능
            if(isConv == false)
            {
                lblResult.Text = "올바른 형식의 숫자를 넣어주세요";
                return;
            }
            //범위체크,
            if (score<0.0 || score>100.0)
            {
                lblResult.Text = "0~100사이의 점수를 넣으시오";
                return;//메소드 종료
            }
            //점수 저장후
            scores[scores_index] = score;
            scores_index++;
            //결과여부 출력
            lblResult.Text =  $"[{scores_index}]{score}점을 입력하였습니다";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //배열이 비었는지 확인
            if(scores_index == 0)
            {
                lblResult.Text = "내용이 없습니다";
                return;
            }
            //평균 max min
            double avg = 0;
            double max = 0;
            double min = 100.0;
            double sum =0;

            string scores_list = string.Empty;
            for(int i=0;i< scores_index; i++)
            {
                sum += scores[i];

                if (max < scores[i])
                {
                    max = scores[i];
                }
                if(min> scores[i])
                {
                    min = scores[i];
                }
                scores_list += scores_list.Length >0 ? $",{scores[i]:F2}점" : $"{scores[i]:F2}점";
            }
            avg = sum / scores_index;

            string message =
                $"현재인원 : {scores_index}명 \n" +
                $"전체점수 : {scores_list} \n" +
                $"평균 : {avg:F2} \n" +
                $"최고점 : {max:F2} \n" +
                $"최저점 : {min:F2} \n";
            //  $"현재인원: {scores_index}명" + Environment.NewLine 도 가능 +연산자 많으면 안좋음
            lblResult.Text = message;
        }
    }
}
