
namespace WindowsFormsApp4
{
    partial class FornInfo
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
            this.tbxnumber = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.tbxscore = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.tbxoutput = new System.Windows.Forms.TextBox();
            this.btnview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxnumber
            // 
            this.tbxnumber.Location = new System.Drawing.Point(87, 82);
            this.tbxnumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxnumber.Name = "tbxnumber";
            this.tbxnumber.Size = new System.Drawing.Size(169, 32);
            this.tbxnumber.TabIndex = 0;
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(327, 82);
            this.tbxname.Margin = new System.Windows.Forms.Padding(5);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(169, 32);
            this.tbxname.TabIndex = 0;
            // 
            // tbxscore
            // 
            this.tbxscore.Location = new System.Drawing.Point(631, 82);
            this.tbxscore.Margin = new System.Windows.Forms.Padding(5);
            this.tbxscore.Name = "tbxscore";
            this.tbxscore.Size = new System.Drawing.Size(169, 32);
            this.tbxscore.TabIndex = 0;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(856, 82);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(151, 32);
            this.btnnew.TabIndex = 1;
            this.btnnew.Text = "신규입력";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // tbxoutput
            // 
            this.tbxoutput.Location = new System.Drawing.Point(87, 215);
            this.tbxoutput.Margin = new System.Windows.Forms.Padding(5);
            this.tbxoutput.Multiline = true;
            this.tbxoutput.Name = "tbxoutput";
            this.tbxoutput.ReadOnly = true;
            this.tbxoutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxoutput.Size = new System.Drawing.Size(864, 238);
            this.tbxoutput.TabIndex = 0;
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(856, 140);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(151, 32);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "전체조회";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // FornInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 637);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.tbxscore);
            this.Controls.Add(this.tbxname);
            this.Controls.Add(this.tbxoutput);
            this.Controls.Add(this.tbxnumber);
            this.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FornInfo";
            this.Text = "학생관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxnumber;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.TextBox tbxscore;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox tbxoutput;
        private System.Windows.Forms.Button btnview;
    }
}

