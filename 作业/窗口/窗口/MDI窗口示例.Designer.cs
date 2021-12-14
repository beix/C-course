namespace 窗口
{
    partial class MDI窗口示例
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多级菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一级菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二级菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二级菜单BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.打开toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.设置TToolStripMenuItem,
            this.多级菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.文件FToolStripMenuItem.Text = "文件（&F）";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.打开ToolStripMenuItem.Text = "打开(&O)";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 设置TToolStripMenuItem
            // 
            this.设置TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选中ToolStripMenuItem});
            this.设置TToolStripMenuItem.Name = "设置TToolStripMenuItem";
            this.设置TToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.设置TToolStripMenuItem.Text = "设置(&T)";
            // 
            // 选中ToolStripMenuItem
            // 
            this.选中ToolStripMenuItem.Checked = true;
            this.选中ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.选中ToolStripMenuItem.Name = "选中ToolStripMenuItem";
            this.选中ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.选中ToolStripMenuItem.Text = "选中";
            this.选中ToolStripMenuItem.Click += new System.EventHandler(this.选中ToolStripMenuItem_Click);
            // 
            // 多级菜单ToolStripMenuItem
            // 
            this.多级菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一级菜单ToolStripMenuItem});
            this.多级菜单ToolStripMenuItem.Name = "多级菜单ToolStripMenuItem";
            this.多级菜单ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.多级菜单ToolStripMenuItem.Text = "多级菜单";
            // 
            // 一级菜单ToolStripMenuItem
            // 
            this.一级菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.二级菜单ToolStripMenuItem,
            this.二级菜单BToolStripMenuItem});
            this.一级菜单ToolStripMenuItem.Name = "一级菜单ToolStripMenuItem";
            this.一级菜单ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.一级菜单ToolStripMenuItem.Text = "一级菜单";
            // 
            // 二级菜单ToolStripMenuItem
            // 
            this.二级菜单ToolStripMenuItem.Name = "二级菜单ToolStripMenuItem";
            this.二级菜单ToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.二级菜单ToolStripMenuItem.Text = "二级菜单A";
            // 
            // 二级菜单BToolStripMenuItem
            // 
            this.二级菜单BToolStripMenuItem.Name = "二级菜单BToolStripMenuItem";
            this.二级菜单BToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.二级菜单BToolStripMenuItem.Text = "二级菜单B";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(631, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // 打开toolStripButton
            // 
            this.打开toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开toolStripButton.Image = global::窗口.Properties.Resources.open;
            this.打开toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开toolStripButton.Name = "打开toolStripButton";
            this.打开toolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.打开toolStripButton.Size = new System.Drawing.Size(23, 22);
            this.打开toolStripButton.Text = "打开";
            this.打开toolStripButton.Click += new System.EventHandler(this.打开toolStripButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(631, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel1.Text = "欢迎光临";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MDI窗口示例
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::窗口.Properties.Resources.bgUser;
            this.ClientSize = new System.Drawing.Size(631, 402);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI窗口示例";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI窗口示例";
            this.Load += new System.EventHandler(this.MDI窗口示例_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多级菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一级菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二级菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二级菜单BToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 打开toolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}

