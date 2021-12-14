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

namespace log
{
    public partial class LogWins : Form
    {
        public LogWins()
        {
            InitializeComponent();
        }
        // 窗口加载时，设置默认角色为“收银员”
        private void frm_Login_Load(object sender, EventArgs e)
        {
            // 禁止Tab键停留到LinkLabel上
            /*this.ll_Register.TabStop = false;
            this.ll_Forget.TabStop = false;*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
            String connStr = ConfigurationManager.ConnectionStrings["SuperMarketSales"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令发送给数据库
                String sqlStr = "select * from EMPLOYEE where ID=@id and PASSWORD=@pwd";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // 注意是用用户ID登录，而不是用户名，用户名可能会重复
                cmd.Parameters.Add(new SqlParameter("@id", this.mTb_user.Text.Trim()));
                cmd.Parameters.Add(new SqlParameter("@pwd", this.mTb_passworld.Text.Trim()));

                SqlDataReader dr = cmd.ExecuteReader();

                // 如果从数据库中查询到记录，则表示可以登录
                if (dr.HasRows)
                {
                    dr.Read();
                    UserInfo.userId = int.Parse(dr["ID"].ToString());
                    UserInfo.userName = dr["NAME"].ToString();
                    UserInfo.userPwd = dr["PASSWORD"].ToString();
                    UserInfo.userType = dr["TYPE"].ToString();
                    UserInfo.userPhone = dr["PHONE"].ToString();

                    MessageBox.Show(UserInfo.userType + "登录成功");

                    if (UserInfo.userType == "收银员")
                     {
                         // 显示收银员主界面
                         CashierWins formUser = new CashierWins();
                         formUser.Show();

                         // 隐藏登录界面
                         this.Hide();
                     }                  

                     if (UserInfo.userType == "库管员")
                     {
                         // 显示库管员主界面
                         AdministratorWins formAdmin = new AdministratorWins();
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
                MessageBox.Show("访问数据库错误：" + exp.ToString());
            }
            finally
            {
                sqlConn.Close();
            }
            /*if (this.mCb.SelectedItem.ToString() == "管理员") {
                if (this.mTb_user.Text == "123" && this.mTb_passworld.Text == "123")
                {
                    AdministratorWins admin = new AdministratorWins();
                    admin.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }else if (this.mCb.SelectedItem.ToString() == "收银员")
            {
                if (this.mTb_user.Text == "123" && this.mTb_passworld.Text == "123")
                {
                    CashierName Cashier = new CashierName();
                    Cashier.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }*/

            /*    String connStr = "Data Source=.;Initial Catalog=SupermarketAdmin;Integrated Security=True";
                SqlConnection sqlConn = new SqlConnection(connStr);

                try
                {
                    sqlConn.Open();

                    String sqlStr = "";

                    if (this.mCb.SelectedItem.ToString() == "收银员")
                    {
                        // 注意USER是SQL Server关键字，表名不能命名为USER，而应当用USERS
                        sqlStr = "select * from Cashier where jobNumber=@id and PASSWORD=@pwd";
                    }
                    else
                    {
                        sqlStr = "select * from Warehouser where jobNumber=@id and PASSWORD=@pwd";
                    }

                    SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                    // 注意是用用户ID登录，而不是用户名，用户名可能会重复
                    cmd.Parameters.Add(new SqlParameter("@id", this.mTb_user.Text.Trim()));
                    cmd.Parameters.Add(new SqlParameter("@pwd", this.mTb_passworld.Text.Trim()));

                    SqlDataReader dr = cmd.ExecuteReader();

                    // 如果从数据库中查询到记录，则表示可以登录
                    if (dr.HasRows)
                    {
                        dr.Read();
                        UserInfo.userId = int.Parse(dr["jobNumber"].ToString());
                        UserInfo.userName = dr["NAME"].ToString();
                        UserInfo.userPwd = dr["PASSWORD"].ToString();
                        UserInfo.userPhone = dr["PHONE"].ToString();
                        UserInfo.userType = this.mCb.SelectedItem.ToString();

                        MessageBox.Show(UserInfo.userType + "登录成功");

                        if (UserInfo.userType == "收银员")
                        {
                            // 显示收银员主界面
                            CashierName Cashier = new CashierName();
                            Cashier.Show();
                            this.Hide();
                         }
                        if (UserInfo.userType == "库管员")
                        {
                            // 显示库管员主界面
                            AdministratorWins admin = new AdministratorWins();
                            admin.Show();
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
                    MessageBox.Show("数据库连接失败"+ exp.Message);
                }
                finally
                {
                    sqlConn.Close();
                }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mTb_passworld_TextChanged(object sender, EventArgs e)
        {
            this.mTb_passworld.PasswordChar = '*';
        }

        private void LogWins_Load(object sender, EventArgs e)
        {

        }


   

  
       
    }
}
