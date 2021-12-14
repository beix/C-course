namespace SuperMarketSales
{
    partial class PwdForm
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
            this.tb_User = new System.Windows.Forms.TextBox();
            this.tb_NewPwd = new System.Windows.Forms.TextBox();
            this.tb_ConfirmPwd = new System.Windows.Forms.TextBox();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.28571F);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.28571F);
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.28571F);
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_User
            // 
            this.tb_User.Enabled = false;
            this.tb_User.Location = new System.Drawing.Point(208, 52);
            this.tb_User.MaxLength = 9;
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(156, 25);
            this.tb_User.TabIndex = 3;
            // 
            // tb_NewPwd
            // 
            this.tb_NewPwd.Location = new System.Drawing.Point(208, 96);
            this.tb_NewPwd.MaxLength = 9;
            this.tb_NewPwd.Name = "tb_NewPwd";
            this.tb_NewPwd.PasswordChar = '*';
            this.tb_NewPwd.Size = new System.Drawing.Size(156, 25);
            this.tb_NewPwd.TabIndex = 4;
            this.tb_NewPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_NewPwd_KeyPress);
            // 
            // tb_ConfirmPwd
            // 
            this.tb_ConfirmPwd.Location = new System.Drawing.Point(208, 140);
            this.tb_ConfirmPwd.MaxLength = 9;
            this.tb_ConfirmPwd.Name = "tb_ConfirmPwd";
            this.tb_ConfirmPwd.PasswordChar = '*';
            this.tb_ConfirmPwd.Size = new System.Drawing.Size(156, 25);
            this.tb_ConfirmPwd.TabIndex = 5;
            this.tb_ConfirmPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ConfirmPwd_KeyPress);
            // 
            // bt_Ok
            // 
            this.bt_Ok.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Ok.Location = new System.Drawing.Point(94, 234);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(99, 37);
            this.bt_Ok.TabIndex = 6;
            this.bt_Ok.Text = "确定";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Cancel.Location = new System.Drawing.Point(265, 234);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(99, 37);
            this.bt_Cancel.TabIndex = 7;
            this.bt_Cancel.Text = "取消";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // PwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 314);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.tb_ConfirmPwd);
            this.Controls.Add(this.tb_NewPwd);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PwdForm";
            this.Text = "修改用户密码";
            this.Load += new System.EventHandler(this.PwdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.TextBox tb_NewPwd;
        private System.Windows.Forms.TextBox tb_ConfirmPwd;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Button bt_Cancel;
    }
}