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
using System.Configuration;

namespace SuperMarketSales
{
    public partial class PwdForm : Form
    {
        public PwdForm()
        {
            InitializeComponent();
        }

        private void PwdForm_Load(object sender, EventArgs e)
        {
            this.tb_User.Text = UserInfo.userName;
        }

        // 点击“取消”按钮
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 点击“确认”按钮
        private void bt_Ok_Click(object sender, EventArgs e)
        {
            String userName = this.tb_User.Text.Trim();
            String newPwd = this.tb_NewPwd.Text.Trim();
            String confPwd = this.tb_ConfirmPwd.Text.Trim();

            // 验证输入信息
            if (newPwd.Equals(""))
            {
                MessageBox.Show("请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (confPwd.Equals(""))
            {
                MessageBox.Show("请输入确认密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (newPwd != confPwd)
            {
                MessageBox.Show("两次密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 连接字符串，注意与实际环境保持一致
            String connStr = ConfigurationManager.ConnectionStrings["SuperMarketSales"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令
                String sqlStr = "update EMPLOYEE set PASSWORD=@pwd where ID=@id";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // SQL字符串参数赋值
                cmd.Parameters.Add(new SqlParameter("@pwd", newPwd));
                cmd.Parameters.Add(new SqlParameter("@id", UserInfo.userId));

                // 将命令发送给数据库
                int res = cmd.ExecuteNonQuery();

                // 根据返回值判断是否修改成功
                if (res != 0)
                {
                    MessageBox.Show("密码修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码修改错误");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("访问数据库错误：" + exp.ToString());
            }
            finally
            {
                sqlConn.Close();
            }
        }

        // 在“新密码”输入框中按“回车”，光标跳转到“确认密码”输入框
        private void tb_NewPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        // 在“确认密码”输入框中按“回车”，则直接修改密码
        private void tb_ConfirmPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.bt_Ok_Click(sender, e);
            }
        }
    }
}