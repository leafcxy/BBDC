namespace BBDC.UI
{
    partial class FrmUserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuestion = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.labImage = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQRPwd = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtNmae = new System.Windows.Forms.TextBox();
            this.lblQRPwd = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtQuestion.FormattingEnabled = true;
            this.txtQuestion.Items.AddRange(new object[] {
            "爸爸名字",
            "妈妈名字",
            "学校名字"});
            this.txtQuestion.Location = new System.Drawing.Point(127, 231);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(100, 20);
            this.txtQuestion.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(211, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(360, 140);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 26;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            this.btnSelectFile.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSelectFile_Paint);
            // 
            // labImage
            // 
            this.labImage.AutoSize = true;
            this.labImage.Location = new System.Drawing.Point(268, 145);
            this.labImage.Name = "labImage";
            this.labImage.Size = new System.Drawing.Size(41, 12);
            this.labImage.TabIndex = 25;
            this.labImage.Text = "头像：";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(360, 234);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 21);
            this.txtAnswer.TabIndex = 24;
            // 
            // txtQRPwd
            // 
            this.txtQRPwd.Location = new System.Drawing.Point(360, 191);
            this.txtQRPwd.Name = "txtQRPwd";
            this.txtQRPwd.PasswordChar = '*';
            this.txtQRPwd.Size = new System.Drawing.Size(100, 21);
            this.txtQRPwd.TabIndex = 23;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(127, 188);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 22;
            // 
            // txtNmae
            // 
            this.txtNmae.Location = new System.Drawing.Point(127, 145);
            this.txtNmae.Name = "txtNmae";
            this.txtNmae.Size = new System.Drawing.Size(100, 21);
            this.txtNmae.TabIndex = 21;
            // 
            // lblQRPwd
            // 
            this.lblQRPwd.AutoSize = true;
            this.lblQRPwd.Location = new System.Drawing.Point(268, 191);
            this.lblQRPwd.Name = "lblQRPwd";
            this.lblQRPwd.Size = new System.Drawing.Size(65, 12);
            this.lblQRPwd.TabIndex = 20;
            this.lblQRPwd.Text = "确认密码：";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(268, 237);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(65, 12);
            this.lblAnswer.TabIndex = 19;
            this.lblAnswer.Text = "密保答案：";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(35, 234);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(65, 12);
            this.lblQuestion.TabIndex = 18;
            this.lblQuestion.Text = "密保问题：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(35, 191);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 12);
            this.lblPwd.TabIndex = 17;
            this.lblPwd.Text = "新密码：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "昵称：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 320);
            this.panel1.TabIndex = 31;
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 345);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.labImage);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQRPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtNmae);
            this.Controls.Add(this.lblQRPwd);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUserInfo";
            this.Text = "个人信息";
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtQuestion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label labImage;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQRPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNmae;
        private System.Windows.Forms.Label lblQRPwd;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}