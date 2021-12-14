using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace my_login
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_Register_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Agriculture"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令发送给数据库
                String sqlStr = "insert into Users (email, password, name, type) values(@email, @pwd, @name, '操作员')";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // 注意是用用户ID登录，而不是用户名，用户名可能会重复
                cmd.Parameters.Add(new SqlParameter("@email", this.email.Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@pwd", this.password.Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@name", this.name.Value.ToString()));

                // 将命令发送给数据库
                int res = cmd.ExecuteNonQuery();

                // 根据返回值判断是否插入成功
                if (res != 0)
                {
                    this.Response.Write("<script>alert('注册成功，请登录');window.location='login.aspx';</script>");
                }
                else
                {
                    this.Response.Write("<script>alert('注册失败');</script>");
                }
            }
            catch (InvalidOperationException exp)
            {
                this.Response.Write("<script>alert('无法连接到数据库');</script>");
            }
            catch (SqlException exp)
            {
                this.Response.Write("<script>alert('数据库操作失败。已存在该用户?');</script>");
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