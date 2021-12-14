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
                    MessageBox.Show("用户名或密码错误");
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
                    MessageBox.Show("用户名或密码错误");
                }
            }

        }

        // 点击“退出”按钮则退出应用程序
        private void bt_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
