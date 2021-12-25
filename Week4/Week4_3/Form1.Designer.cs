
namespace Week4_3
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
            this.tbxKor = new System.Windows.Forms.TextBox();
            this.tbxEng = new System.Windows.Forms.TextBox();
            this.tbxMat = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxKor
            // 
            this.tbxKor.Font = new System.Drawing.Font("궁서", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxKor.Location = new System.Drawing.Point(229, 12);
            this.tbxKor.Name = "tbxKor";
            this.tbxKor.Size = new System.Drawing.Size(100, 26);
            this.tbxKor.TabIndex = 10;
            // 
            // tbxEng
            // 
            this.tbxEng.Font = new System.Drawing.Font("궁서", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxEng.Location = new System.Drawing.Point(335, 16);
            this.tbxEng.Name = "tbxEng";
            this.tbxEng.Size = new System.Drawing.Size(100, 26);
            this.tbxEng.TabIndex = 11;
            // 
            // tbxMat
            // 
            this.tbxMat.Font = new System.Drawing.Font("궁서", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxMat.Location = new System.Drawing.Point(441, 16);
            this.tbxMat.Name = "tbxMat";
            this.tbxMat.Size = new System.Drawing.Size(100, 26);
            this.tbxMat.TabIndex = 12;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblResult.Font = new System.Drawing.Font("궁서", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(0, 157);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(947, 354);
            this.lblResult.TabIndex = 9;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("궁서", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnView.Location = new System.Drawing.Point(730, 19);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "결과";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("궁서", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInput.Location = new System.Drawing.Point(559, 19);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 8;
            this.btnInput.Text = "입력";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("궁서", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxName.Location = new System.Drawing.Point(125, 12);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 26);
            this.tbxName.TabIndex = 11;
            // 
            // tbxNum
            // 
            this.tbxNum.Font = new System.Drawing.Font("궁서", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxNum.Location = new System.Drawing.Point(19, 12);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(100, 26);
            this.tbxNum.TabIndex = 10;
            this.tbxNum.TextChanged += new System.EventHandler(this.tbxNum_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 511);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxKor);
            this.Controls.Add(this.tbxEng);
            this.Controls.Add(this.tbxMat);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnInput);
            this.Name = "Form1";
            this.Text = "4주차(3)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKor;
        private System.Windows.Forms.TextBox tbxEng;
        private System.Windows.Forms.TextBox tbxMat;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxNum;
    }
}

