using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int currIndex = 0;
        string[,] info = new string[10, 2]; //10명 (학번,이름)
        double[,] scores = new double[10, 3];
        private void btnInput_Click(object sender, EventArgs e)
        {//입력
            if (currIndex >= scores.GetLength(0)) //length쓰면 30이 세짐,getlength 는 0은 1차원 1은 2차원배열의 길이가 세짐
            {
                lblResult.Text = "더 이상 입력을 할 수 없습니다.";
                return;
            }
            /*if(tbxNum.Text.Trim() == "" || tbxName.Text.Trim() =="")
            {
                lblResult.Text = "학번,이름을 입력해주세요";
                return;
            }*/
            if (string.IsNullOrWhiteSpace(tbxNum.Text) //null이거나 공백이 들어가잇으면
                || string.IsNullOrWhiteSpace(tbxName.Text))
            {
                lblResult.Text = "학번,이름을 입력해주세요";
                return;
            }


            if (false == double.TryParse(tbxKor.Text, out double scoreKor)
            || false == double.TryParse(tbxEng.Text, out double scoreEng)
            || false == double.TryParse(tbxMat.Text, out double scoreMat))
            {
                lblResult.Text = "정확한 값을 넣어주세요";
                return;
            }
            //범위계산
            if (scoreKor < 0.0 || scoreKor > 100.0
            || scoreEng < 0.0 || scoreEng > 100.0
            || scoreMat < 0.0 || scoreMat > 100.0)
            {
                lblResult.Text = "0~100 사이의 점수를 넣어주세요";
                return;
            }

            for(int i=0; i<currIndex; i++)
            {
                if(info[i,0]==tbxNum.Text.Trim())
                {
                    lblResult.Text = "동일한 학번 사용 불가";
                    return;
                }
            }

            info[currIndex, 0] = tbxNum.Text.Trim();
            info[currIndex, 1] = tbxName.Text.Trim();
            scores[currIndex, 0] = scoreKor;
            scores[currIndex, 1] = scoreEng;
            scores[currIndex, 2] = scoreMat;

            

            lblResult.Text = $"[{info[currIndex, 0]}/{info[currIndex, 1]}] 국어:{scoreKor},영어: {scoreEng}, 수학:{scoreMat}";
            currIndex++;
        }

        private void btnView_Click(object sender, EventArgs e)
        {//분석
            if (currIndex == 0)
            {
                lblResult.Text = "조회할 내용이없음";
                return;
            }
            string scores_list = "";
            double avg = 0.0;
            double max = 0.0;
            double min = 100.0;
            double sum = 0;

            for (int i = 0; i < currIndex; i++)//학생수
            {
                double sub_sum = 0.0, sub_avg = 0.0;
                string sub_score_List = "";

                for (int j = 0; j < scores.GetLength(1); j++)
                {//i번학생의 j개 과목 돌면서 검사
                    sub_sum += scores[i, j];
                    sub_score_List += sub_score_List.Length > 0 ? $",{scores[i, j]}" : $"[{info[i,0]}/{info[i,1]}]{scores[i, j]}";
                }

                sub_avg = sub_sum / scores.GetLength(1);
                sub_score_List += $"=>평균 :{sub_avg,8:F2}";

                sum += sub_avg;
                if (max < sub_avg) { max = sub_avg; }
                if (min > sub_avg) { min = sub_avg; }

                scores_list += sub_score_List + Environment.NewLine;

            }
            avg = sum / currIndex;

            string message =
                $"현재인원 : {currIndex}명 {Environment.NewLine}" +
                $"전체점수 : {Environment.NewLine}{scores_list}" +
                $"평균 : {avg:F2} {Environment.NewLine}" +
                $"최고점 : {max:F2} {Environment.NewLine}" +
                $"최저점 : {min:F2} {Environment.NewLine}";

            lblResult.Text = message;
        }

        private void tbxNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
