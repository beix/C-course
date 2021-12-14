using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace aspLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_Login_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Agriculture"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令发送给数据库
                String sqlStr = "select * from Users where email=@email and password=@pwd";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // 注意是用用户ID登录，而不是用户名，用户名可能会重复
                cmd.Parameters.Add(new SqlParameter("@email", this.tb_Email.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pwd", this.tb_Password.Text.ToString()));

                SqlDataReader dr = cmd.ExecuteReader();

                // 如果从数据库中查询到记录，则表示可以登录
                if (dr.HasRows)
                {
                    this.Response.Write("<script>alert('登录成功');</script>");
                }
                else
                {
                    this.Response.Write("<script>alert('用户名或密码错误');</script>");
                }
            }
            catch (InvalidOperationException exp)
            {
                this.Response.Write("<script>alert('无法连接到数据库');</script>");
            }
            catch (SqlException exp)
            {
                this.Response.Write("<script>alert('数据库操作失败。不存在该用户?');</script>");
            }
            catch (Exception exp)
            {
                this.Response.Write("<script>alert('未知错误');</script>");
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}