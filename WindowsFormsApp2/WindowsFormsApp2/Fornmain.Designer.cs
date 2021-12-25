
namespace WindowsFormsApp2
{
    partial class Fornmain
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
            this.tbxOperand1 = new System.Windows.Forms.TextBox();
            this.tbxOperand2 = new System.Windows.Forms.TextBox();
            this.chkFloat = new System.Windows.Forms.CheckBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxOperand1
            // 
            this.tbxOperand1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxOperand1.Location = new System.Drawing.Point(230, 140);
            this.tbxOperand1.Name = "tbxOperand1";
            this.tbxOperand1.Size = new System.Drawing.Size(148, 35);
            this.tbxOperand1.TabIndex = 0;
            // 
            // tbxOperand2
            // 
            this.tbxOperand2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxOperand2.Location = new System.Drawing.Point(451, 140);
            this.tbxOperand2.Name = "tbxOperand2";
            this.tbxOperand2.Size = new System.Drawing.Size(148, 35);
            this.tbxOperand2.TabIndex = 1;
            // 
            // chkFloat
            // 
            this.chkFloat.AutoSize = true;
            this.chkFloat.Checked = true;
            this.chkFloat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFloat.Location = new System.Drawing.Point(768, 171);
            this.chkFloat.Name = "chkFloat";
            this.chkFloat.Size = new System.Drawing.Size(48, 16);
            this.chkFloat.TabIndex = 2;
            this.chkFloat.Text = "실수";
            this.chkFloat.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(230, 248);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(133, 100);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "더하기";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblresult
            // 
            this.lblresult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresult.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblresult.Location = new System.Drawing.Point(451, 248);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(136, 82);
            this.lblresult.TabIndex = 4;
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Fornmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 608);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.chkFloat);
            this.Controls.Add(this.tbxOperand2);
            this.Controls.Add(this.tbxOperand1);
            this.Name = "Fornmain";
            this.Text = "2주차";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOperand1;
        private System.Windows.Forms.TextBox tbxOperand2;
        private System.Windows.Forms.CheckBox chkFloat;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblresult;
    }
}

