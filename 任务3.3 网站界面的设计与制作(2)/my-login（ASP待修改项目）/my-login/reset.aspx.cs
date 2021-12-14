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
    public partial class reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_Reset_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["Agriculture"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令发送给数据库
                String sqlStr = "update Users set password=@pwd where email=@email";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // 注意是用用户ID登录，而不是用户名，用户名可能会重复
                cmd.Parameters.Add(new SqlParameter("@pwd", this.new_password.Value.ToString()));
                cmd.Parameters.Add(new SqlParameter("@email", Context.User.Identity.Name));

                // 将命令发送给数据库
                int res = cmd.ExecuteNonQuery();

                // 根据返回值判断是否更新成功
                if (res != 0)
                {
                    this.Response.Write("<script>alert('更新成功，请重新登录');window.location='login.aspx';</script>");
                }
                else
                {
                    this.Response.Write("<script>alert('更新失败');</script>");
                }
            }
            catch (InvalidOperationException exp)
            {
                this.Response.Write("<script>alert('无法连接到数据库');</script>");
            }
            catch (SqlException exp)
            {
                this.Response.Write("<script>alert('数据库操作失败');</script>");
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