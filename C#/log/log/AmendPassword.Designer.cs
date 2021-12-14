namespace log
{
    partial class AmendPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mYes = new System.Windows.Forms.Button();
            this.mExit = new System.Windows.Forms.Button();
            this.mOldpassword = new System.Windows.Forms.TextBox();
            this.mNewpassword = new System.Windows.Forms.TextBox();
            this.mNextpassword = new System.Windows.Forms.TextBox();
            this.mId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "原密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码：";
            // 
            // mYes
            // 
            this.mYes.Location = new System.Drawing.Point(88, 249);
            this.mYes.Margin = new System.Windows.Forms.Padding(4);
            this.mYes.Name = "mYes";
            this.mYes.Size = new System.Drawing.Size(100, 29);
            this.mYes.TabIndex = 4;
            this.mYes.Text = "确定";
            this.mYes.UseVisualStyleBackColor = true;
            this.mYes.Click += new System.EventHandler(this.mYes_Click);
            // 
            // mExit
            // 
            this.mExit.Location = new System.Drawing.Point(197, 249);
            this.mExit.Margin = new System.Windows.Forms.Padding(4);
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(100, 29);
            this.mExit.TabIndex = 5;
            this.mExit.Text = "退出";
            this.mExit.UseVisualStyleBackColor = true;
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mOldpassword
            // 
            this.mOldpassword.Location = new System.Drawing.Point(149, 106);
            this.mOldpassword.Margin = new System.Windows.Forms.Padding(4);
            this.mOldpassword.Name = "mOldpassword";
            this.mOldpassword.Size = new System.Drawing.Size(132, 25);
            this.mOldpassword.TabIndex = 7;
            // 
            // mNewpassword
            // 
            this.mNewpassword.Location = new System.Drawing.Point(149, 149);
            this.mNewpassword.Margin = new System.Windows.Forms.Padding(4);
            this.mNewpassword.Name = "mNewpassword";
            this.mNewpassword.Size = new System.Drawing.Size(132, 25);
            this.mNewpassword.TabIndex = 8;
            // 
            // mNextpassword
            // 
            this.mNextpassword.Location = new System.Drawing.Point(149, 192);
            this.mNextpassword.Margin = new System.Windows.Forms.Padding(4);
            this.mNextpassword.Name = "mNextpassword";
            this.mNextpassword.Size = new System.Drawing.Size(132, 25);
            this.mNextpassword.TabIndex = 9;
            // 
            // mId
            // 
            this.mId.AutoSize = true;
            this.mId.Location = new System.Drawing.Point(149, 69);
            this.mId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mId.Name = "mId";
            this.mId.Size = new System.Drawing.Size(55, 15);
            this.mId.TabIndex = 10;
            this.mId.Text = "label5";
            // 
            // AmendPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 328);
            this.Controls.Add(this.mId);
            this.Controls.Add(this.mNextpassword);
            this.Controls.Add(this.mNewpassword);
            this.Controls.Add(this.mOldpassword);
            this.Controls.Add(this.mExit);
            this.Controls.Add(this.mYes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AmendPassword";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.AmendPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mYes;
        private System.Windows.Forms.Button mExit;
        private System.Windows.Forms.TextBox mOldpassword;
        private System.Windows.Forms.TextBox mNewpassword;
        private System.Windows.Forms.TextBox mNextpassword;
        private System.Windows.Forms.Label mId;
    }
}