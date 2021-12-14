using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tab键登陆
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        // 窗口加载时，设置默认角色为“收银员”
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.cbb_Type.SelectedIndex = 0;
        }

        // 点击“登录”按钮则登录系统
        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (this.cbb_Type.SelectedItem.ToString() == "收银员")
            {
                if (this.tb_User.Text == "123456" && this.tb_Password.Text == "123456")
                {
                    MessageBox.Show("收银员登录成功");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (this.cbb_Type.SelectedItem.ToString() == "库管员")
            {
                if (this.tb_User.Text == "admin" && this.tb_Password.Text == "admin")
                {
                    MessageBox.Show("库管员登录成功");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        // 点击“退出”按钮则退出应用程序
        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 在用户名输入框中按“回车”，光标跳转到密码输入框
        private void tb_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        // 在密码输入框中按“回车”，则直接登录
        private void tb_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.bt_Login_Click(sender, e);
            }
        }

        // Tab进入用户名输入框时，自动全选用户名
        private void tb_User_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        // Tab进入密码输入框时，自动全选密码
        private void tb_Password_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void tb_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }

        private void cbb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
