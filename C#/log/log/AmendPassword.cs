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

namespace log
{
    public partial class AmendPassword : Form
    {
        public AmendPassword()
        {
            InitializeComponent();
            this.mId.Text = UserInfo.userName;
        }

        private void mYes_Click(object sender, EventArgs e)
        {
            this.mId.Text = UserInfo.userName;
            String connStr = "Data Source=.;Initial Catalog=SupermarketAdmin;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                sqlConn.Open();
                String userName = this.mId.Text;
                String oldPwd = this.mOldpassword.Text.Trim();
                String newPwd = this.mNewpassword.Text.Trim();
                String nextPwd = this.mNextpassword.Text.Trim();

                // 验证输入信息
                if (oldPwd.Equals(""))
                {
                    MessageBox.Show("请输入旧密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (oldPwd != UserInfo.userPwd)
                {
                    MessageBox.Show("与原密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (newPwd.Equals(""))
                {
                    MessageBox.Show("请输入新密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (nextPwd.Equals(""))
                {
                    MessageBox.Show("请输入确认密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                else if (newPwd != nextPwd)
                {
                    MessageBox.Show("两次密码不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // 构造UPDATE命令
                String sqlStr = "update Warehouser set password=@pwd where jobNumber=@id";

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
                MessageBox.Show("访问数据库错误：" + exp.Message);
            }
            finally
            {
                sqlConn.Close();
            }

        }

        private void AmendPassword_Load(object sender, EventArgs e)
        {

        }
        private void mExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
