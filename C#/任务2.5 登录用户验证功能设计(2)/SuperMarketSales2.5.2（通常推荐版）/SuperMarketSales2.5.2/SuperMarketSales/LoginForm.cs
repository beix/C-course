using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarketSales
{
    public partial class LoginForm : Form
    {
        // 构造函数
        public LoginForm()
        {
            InitializeComponent();
        }

        // 窗口加载时，设置默认角色为“收银员”
        private void frm_Login_Load(object sender, EventArgs e)
        {
            // 设置收银员为默认登录类型
            this.cbb_UserType.SelectedIndex = 0;

            // 禁止Tab键停留到LinkLabel上
            this.ll_Register.TabStop = false;
            this.ll_Forget.TabStop = false;
        }

        // 点击“登录”按钮则登录系统
        private void bt_Login_Click(object sender, EventArgs e)
        {
            String connStr = "Data Source=.;Initial Catalog=SuperMarketSales;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                sqlConn.Open();

                String sqlStr = "";

                if (this.cbb_UserType.Text == "收银员")
                {
                    // 注意USER是SQL Server关键字，表名不能命名为USER，而应当用USERS
                    sqlStr = "select * from USERS where ID=@id and PASSWORD=@pwd";
                }
                else
                {
                    sqlStr = "select * from ADMIN where ID=@id and PASSWORD=@pwd";
                }

                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // 注意是用用户ID登录，而不是用户名，用户名可能会重复
                cmd.Parameters.Add(new SqlParameter("@id", this.tb_User.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@pwd", this.tb_Password.Text.Trim()));

                SqlDataReader dr = cmd.ExecuteReader();

                // 如果从数据库中查询到记录，则表示可以登录
                if (dr.HasRows)
                {
                    dr.Read();
                    UserInfo.userId = int.Parse(dr["ID"].ToString());
                    UserInfo.userName = dr["NAME"].ToString();
                    UserInfo.userPwd = dr["PASSWORD"].ToString();
                    UserInfo.userPhone = dr["PHONE"].ToString();
                    UserInfo.userType = this.cbb_UserType.Text;

                    MessageBox.Show(UserInfo.userType + "登录成功");

                    if (UserInfo.userType == "收银员")
                    {
                        // 显示收银员主界面
                        MainFormUser formUser = new MainFormUser();
                        formUser.Show();

                        // 隐藏登录界面
                        this.Hide();
                    }

                    if (UserInfo.userType == "库管员")
                    {
                        // 显示库管员主界面
                        MainFormAdmin formAdmin = new MainFormAdmin();
                        formAdmin.Show();

                        // 隐藏登录界面
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("数据库连接失败");
            }
            finally
            {
                sqlConn.Close();
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
    }
}
