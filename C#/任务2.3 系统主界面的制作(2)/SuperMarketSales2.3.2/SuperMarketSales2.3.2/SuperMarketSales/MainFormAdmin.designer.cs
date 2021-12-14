namespace SuperMarketSales
{
    partial class MainFormAdmin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ms_Admin = new System.Windows.Forms.MenuStrip();
            this.tsmi_Password = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_UserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Record = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Admin = new System.Windows.Forms.ToolStrip();
            this.tsb_Password = new System.Windows.Forms.ToolStripButton();
            this.tsb_UserInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_Record = new System.Windows.Forms.ToolStripButton();
            this.tsb_Logout = new System.Windows.Forms.ToolStripButton();
            this.tsb_Exit = new System.Windows.Forms.ToolStripButton();
            this.ss_Admin = new System.Windows.Forms.StatusStrip();
            this.tssl_Welcome = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Event = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_CurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_Admin = new System.Windows.Forms.Timer(this.components);
            this.ms_Admin.SuspendLayout();
            this.ts_Admin.SuspendLayout();
            this.ss_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Admin
            // 
            this.ms_Admin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Password,
            this.tsmi_UserInfo,
            this.tsmi_Record,
            this.tsmi_Logout,
            this.tsmi_Exit});
            this.ms_Admin.Location = new System.Drawing.Point(0, 0);
            this.ms_Admin.Name = "ms_Admin";
            this.ms_Admin.Size = new System.Drawing.Size(603, 28);
            this.ms_Admin.TabIndex = 0;
            this.ms_Admin.Text = "menuStrip1";
            // 
            // tsmi_Password
            // 
            this.tsmi_Password.BackColor = System.Drawing.SystemColors.Control;
            this.tsmi_Password.Name = "tsmi_Password";
            this.tsmi_Password.Size = new System.Drawing.Size(94, 24);
            this.tsmi_Password.Text = "修改密码 &P";
            this.tsmi_Password.Click += new System.EventHandler(this.tsmi_Password_Click);
            // 
            // tsmi_UserInfo
            // 
            this.tsmi_UserInfo.Name = "tsmi_UserInfo";
            this.tsmi_UserInfo.Size = new System.Drawing.Size(119, 24);
            this.tsmi_UserInfo.Text = "修改个人信息 &I";
            this.tsmi_UserInfo.Click += new System.EventHandler(this.tsmi_UserInfo_Click);
            // 
            // tsmi_Record
            // 
            this.tsmi_Record.Name = "tsmi_Record";
            this.tsmi_Record.Size = new System.Drawing.Size(125, 24);
            this.tsmi_Record.Text = "录入商品信息 &R";
            this.tsmi_Record.Click += new System.EventHandler(this.tsmi_Record_Click);
            // 
            // tsmi_Logout
            // 
            this.tsmi_Logout.Name = "tsmi_Logout";
            this.tsmi_Logout.Size = new System.Drawing.Size(63, 24);
            this.tsmi_Logout.Text = "注销 &L";
            this.tsmi_Logout.Click += new System.EventHandler(this.tsmi_Logout_Click);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(63, 24);
            this.tsmi_Exit.Text = "退出 &E";
            this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // ts_Admin
            // 
            this.ts_Admin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ts_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Password,
            this.tsb_UserInfo,
            this.tsb_Record,
            this.tsb_Logout,
            this.tsb_Exit});
            this.ts_Admin.Location = new System.Drawing.Point(0, 28);
            this.ts_Admin.Name = "ts_Admin";
            this.ts_Admin.Size = new System.Drawing.Size(603, 27);
            this.ts_Admin.TabIndex = 1;
            this.ts_Admin.Text = "toolStrip1";
            // 
            // tsb_Password
            // 
            this.tsb_Password.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Password.Image = global::SuperMarketSales.Properties.Resources.Password;
            this.tsb_Password.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Password.Name = "tsb_Password";
            this.tsb_Password.Size = new System.Drawing.Size(24, 24);
            this.tsb_Password.Text = "修改密码";
            this.tsb_Password.Click += new System.EventHandler(this.tsb_Password_Click);
            // 
            // tsb_UserInfo
            // 
            this.tsb_UserInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_UserInfo.Image = global::SuperMarketSales.Properties.Resources.User;
            this.tsb_UserInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_UserInfo.Name = "tsb_UserInfo";
            this.tsb_UserInfo.Size = new System.Drawing.Size(24, 24);
            this.tsb_UserInfo.Text = "修改个人信息";
            this.tsb_UserInfo.Click += new System.EventHandler(this.tsb_UserInfo_Click);
            // 
            // tsb_Record
            // 
            this.tsb_Record.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Record.Image = global::SuperMarketSales.Properties.Resources.Record;
            this.tsb_Record.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Record.Name = "tsb_Record";
            this.tsb_Record.Size = new System.Drawing.Size(24, 24);
            this.tsb_Record.Text = "查询商品信息";
            this.tsb_Record.Click += new System.EventHandler(this.tsb_Record_Click);
            // 
            // tsb_Logout
            // 
            this.tsb_Logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Logout.Image = global::SuperMarketSales.Properties.Resources.Logout;
            this.tsb_Logout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Logout.Name = "tsb_Logout";
            this.tsb_Logout.Size = new System.Drawing.Size(24, 24);
            this.tsb_Logout.Text = "重新登录";
            this.tsb_Logout.Click += new System.EventHandler(this.tsb_Logout_Click);
            // 
            // tsb_Exit
            // 
            this.tsb_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Exit.Image = global::SuperMarketSales.Properties.Resources.Exit;
            this.tsb_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Exit.Name = "tsb_Exit";
            this.tsb_Exit.Size = new System.Drawing.Size(24, 24);
            this.tsb_Exit.Text = "退出";
            this.tsb_Exit.Click += new System.EventHandler(this.tsb_Exit_Click);
            // 
            // ss_Admin
            // 
            this.ss_Admin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Welcome,
            this.tssl_User,
            this.tssl_Event,
            this.tssl_CurrentTime});
            this.ss_Admin.Location = new System.Drawing.Point(0, 315);
            this.ss_Admin.Name = "ss_Admin";
            this.ss_Admin.Size = new System.Drawing.Size(603, 25);
            this.ss_Admin.TabIndex = 2;
            this.ss_Admin.Text = "statusStrip1";
            // 
            // tssl_Welcome
            // 
            this.tssl_Welcome.Name = "tssl_Welcome";
            this.tssl_Welcome.Size = new System.Drawing.Size(39, 20);
            this.tssl_Welcome.Text = "欢迎";
            // 
            // tssl_User
            // 
            this.tssl_User.Name = "tssl_User";
            this.tssl_User.Size = new System.Drawing.Size(33, 20);
            this.tssl_User.Text = "xxx";
            // 
            // tssl_Event
            // 
            this.tssl_Event.Name = "tssl_Event";
            this.tssl_Event.Size = new System.Drawing.Size(189, 20);
            this.tssl_Event.Text = "使用智慧社区商超管理系统";
            // 
            // tssl_CurrentTime
            // 
            this.tssl_CurrentTime.Name = "tssl_CurrentTime";
            this.tssl_CurrentTime.Size = new System.Drawing.Size(296, 20);
            this.tssl_CurrentTime.Spring = true;
            this.tssl_CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_Admin
            // 
            this.timer_Admin.Enabled = true;
            this.timer_Admin.Interval = 1000;
            this.timer_Admin.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperMarketSales.Properties.Resources.bgAdmin;
            this.ClientSize = new System.Drawing.Size(603, 340);
            this.Controls.Add(this.ss_Admin);
            this.Controls.Add(this.ts_Admin);
            this.Controls.Add(this.ms_Admin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_Admin;
            this.Name = "MainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库管员主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ms_Admin.ResumeLayout(false);
            this.ms_Admin.PerformLayout();
            this.ts_Admin.ResumeLayout(false);
            this.ts_Admin.PerformLayout();
            this.ss_Admin.ResumeLayout(false);
            this.ss_Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Admin;
        private System.Windows.Forms.ToolStrip ts_Admin;
        private System.Windows.Forms.StatusStrip ss_Admin;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Password;
        private System.Windows.Forms.ToolStripMenuItem tsmi_UserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Record;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
        private System.Windows.Forms.ToolStripButton tsb_Password;
        private System.Windows.Forms.ToolStripButton tsb_UserInfo;
        private System.Windows.Forms.ToolStripButton tsb_Record;
        private System.Windows.Forms.ToolStripButton tsb_Exit;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Welcome;
        private System.Windows.Forms.ToolStripStatusLabel tssl_User;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Event;
        private System.Windows.Forms.ToolStripStatusLabel tssl_CurrentTime;
        private System.Windows.Forms.Timer timer_Admin;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Logout;
        private System.Windows.Forms.ToolStripButton tsb_Logout;
    }
}

