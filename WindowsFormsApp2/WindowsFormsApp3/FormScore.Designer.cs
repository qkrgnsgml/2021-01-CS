
namespace WindowsFormsApp3
{
    partial class FormScore
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblavg = new System.Windows.Forms.Label();
            this.tbxkor = new System.Windows.Forms.TextBox();
            this.tbxeng = new System.Windows.Forms.TextBox();
            this.tbxmat = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsum = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(103, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(103, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "영어";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(103, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "수학";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblavg
            // 
            this.lblavg.Location = new System.Drawing.Point(317, 275);
            this.lblavg.Name = "lblavg";
            this.lblavg.Size = new System.Drawing.Size(100, 23);
            this.lblavg.TabIndex = 0;
            this.lblavg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxkor
            // 
            this.tbxkor.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxkor.Location = new System.Drawing.Point(307, 73);
            this.tbxkor.Name = "tbxkor";
            this.tbxkor.Size = new System.Drawing.Size(100, 26);
            this.tbxkor.TabIndex = 0;
            this.tbxkor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxeng
            // 
            this.tbxeng.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxeng.Location = new System.Drawing.Point(307, 119);
            this.tbxeng.Name = "tbxeng";
            this.tbxeng.Size = new System.Drawing.Size(100, 26);
            this.tbxeng.TabIndex = 1;
            this.tbxeng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxmat
            // 
            this.tbxmat.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxmat.Location = new System.Drawing.Point(307, 169);
            this.tbxmat.Name = "tbxmat";
            this.tbxmat.Size = new System.Drawing.Size(100, 26);
            this.tbxmat.TabIndex = 2;
            this.tbxmat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncal
            // 
            this.btncal.Location = new System.Drawing.Point(319, 232);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 23);
            this.btncal.TabIndex = 3;
            this.btncal.Text = "계산";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(103, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "평균";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(103, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "합계";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsum
            // 
            this.lblsum.Location = new System.Drawing.Point(317, 314);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(100, 23);
            this.lblsum.TabIndex = 0;
            this.lblsum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblresult
            // 
            this.lblresult.Location = new System.Drawing.Point(317, 352);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(100, 23);
            this.lblresult.TabIndex = 0;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.tbxmat);
            this.Controls.Add(this.tbxeng);
            this.Controls.Add(this.tbxkor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblavg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormScore";
            this.Text = "성적처리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblavg;
        private System.Windows.Forms.TextBox tbxkor;
        private System.Windows.Forms.TextBox tbxeng;
        private System.Windows.Forms.TextBox tbxmat;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.Label lblresult;
    }
}

