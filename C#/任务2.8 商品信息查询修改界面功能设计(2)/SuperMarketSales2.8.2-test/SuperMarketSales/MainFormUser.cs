using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketSales
{
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }

        // 窗口加载时，显示当前时间，显示当前用户名
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.tssl_CurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.tssl_User.Text = UserInfo.userType + UserInfo.userName;
        }

        // 每隔一秒钟更新一下显示时间
        private void timer_User_Tick(object sender, EventArgs e)
        {
            this.tssl_CurrentTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 手动更新一下状态栏显示
            this.ss_User.Refresh();
        }

        // 窗口关闭时，将整个应用程序退出（注意包括登录窗体）
        private void MainFormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // 修改密码
        private void tsmi_Password_Click(object sender, EventArgs e)
        {
            PwdForm pwdForm = new PwdForm();
            pwdForm.MdiParent = this;
            pwdForm.StartPosition = FormStartPosition.CenterScreen;
            pwdForm.Show();
        }

        // 修改用户信息
        private void tsmi_UserInfo_Click(object sender, EventArgs e)
        {

        }

        // 查询商品信息
        private void tsmi_Search_Click(object sender, EventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.MdiParent = this;
            queryForm.WindowState = FormWindowState.Maximized;
            queryForm.Show();
        }

        // 注销当前登录，回到登录界面
        private void tsmi_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认注销？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 重新启动程序，以显示登录窗口
                Application.Restart();
            }
        }

        // 退出系统
        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // 修改密码
        private void tsb_Password_Click(object sender, EventArgs e)
        {
            this.tsmi_Password_Click(sender, e);
        }

        // 修改用户信息
        private void tsb_UserInfo_Click(object sender, EventArgs e)
        {
            this.tsmi_UserInfo_Click(sender, e);
        }

        // 查询商品信息
        private void tsb_Search_Click(object sender, EventArgs e)
        {
            this.tsmi_Search_Click(sender, e);
        }

        // 注销当前登录，回到登录界面
        private void tsb_Logout_Click(object sender, EventArgs e)
        {
            this.tsmi_Logout_Click(sender, e);
        }

        // 退出系统
        private void tsb_Exit_Click(object sender, EventArgs e)
        {
            this.tsmi_Exit_Click(sender, e);
        }
    }
}
