namespace MdiDemo
{
    partial class FormContainer
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
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多级菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一级菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二级菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二级菜单BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Tool = new System.Windows.Forms.ToolStrip();
            this.打开toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ss_Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms_Menu.SuspendLayout();
            this.ts_Tool.SuspendLayout();
            this.ss_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem1,
            this.多级菜单ToolStripMenuItem});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(627, 28);
            this.ms_Menu.TabIndex = 0;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.文件ToolStripMenuItem.Text = "文件（&F）";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.打开ToolStripMenuItem.Text = "打开（&O）";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            this.toolStripSeparator1.Click += new System.EventHandler(this.toolStripSeparator1_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem1
            // 
            this.设置ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选中ToolStripMenuItem});
            this.设置ToolStripMenuItem1.Name = "设置ToolStripMenuItem1";
            this.设置ToolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.设置ToolStripMenuItem1.Text = "设置（&T）";
            // 
            // 选中ToolStripMenuItem
            // 
            this.选中ToolStripMenuItem.Checked = true;
            this.选中ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.选中ToolStripMenuItem.Name = "选中ToolStripMenuItem";
            this.选中ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.选中ToolStripMenuItem.Text = "选中";
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
            // ts_Tool
            // 
            this.ts_Tool.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.ts_Tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开toolStripButton});
            this.ts_Tool.Location = new System.Drawing.Point(0, 28);
            this.ts_Tool.Name = "ts_Tool";
            this.ts_Tool.Size = new System.Drawing.Size(627, 32);
            this.ts_Tool.TabIndex = 2;
            // 
            // 打开toolStripButton
            // 
            this.打开toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开toolStripButton.Image = global::MdiDemo.Properties.Resources.open;
            this.打开toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开toolStripButton.Name = "打开toolStripButton";
            this.打开toolStripButton.Size = new System.Drawing.Size(29, 29);
            this.打开toolStripButton.Text = "打开";
            this.打开toolStripButton.Click += new System.EventHandler(this.打开toolStripButton_Click);
            // 
            // ss_Status
            // 
            this.ss_Status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ss_Status.Location = new System.Drawing.Point(0, 359);
            this.ss_Status.Name = "ss_Status";
            this.ss_Status.Size = new System.Drawing.Size(627, 25);
            this.ss_Status.TabIndex = 4;
            this.ss_Status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel1.Text = "欢迎光临";
            // 
            // FormContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MdiDemo.Properties.Resources.bgUser;
            this.ClientSize = new System.Drawing.Size(627, 384);
            this.Controls.Add(this.ss_Status);
            this.Controls.Add(this.ts_Tool);
            this.Controls.Add(this.ms_Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_Menu;
            this.Name = "FormContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI窗口示例";
            this.Load += new System.EventHandler(this.FormContainer_Load);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ts_Tool.ResumeLayout(false);
            this.ts_Tool.PerformLayout();
            this.ss_Status.ResumeLayout(false);
            this.ss_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多级菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一级菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二级菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二级菜单BToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_Tool;
        private System.Windows.Forms.ToolStripButton 打开toolStripButton;
        private System.Windows.Forms.StatusStrip ss_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        
    }
}

