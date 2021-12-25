
namespace Week6_3
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.tbxView = new System.Windows.Forms.TextBox();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "차량번호";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(165, 102);
            this.btnIn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(118, 40);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "입차";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // tbxView
            // 
            this.tbxView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxView.Location = new System.Drawing.Point(0, 229);
            this.tbxView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxView.Multiline = true;
            this.tbxView.Name = "tbxView";
            this.tbxView.ReadOnly = true;
            this.tbxView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxView.Size = new System.Drawing.Size(981, 296);
            this.tbxView.TabIndex = 2;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(165, 25);
            this.tbxNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(238, 32);
            this.tbxNumber.TabIndex = 2;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(293, 102);
            this.btnOut.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(118, 40);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "출차";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(614, 76);
            this.btnView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(118, 40);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "전체현황";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(981, 525);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.tbxView);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox tbxView;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnView;
    }
}

