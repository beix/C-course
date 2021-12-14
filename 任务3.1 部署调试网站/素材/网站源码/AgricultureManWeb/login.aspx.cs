using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void imgBtnLogin_Click(object sender, ImageClickEventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=acer-PC\\sqlexpress;Initial Catalog=Agriculture;Integrated Security=True");
            string connStr = ConfigurationManager.ConnectionStrings["Agriculture"].ConnectionString;
            SqlConnection con = new SqlConnection(connStr);           
            con.Open();

            string sql = "select * from Operator where opername='" + txtUserName.Text + "' and operpwd='" + txtUserPW.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Session["loginuser"] = reader["opername"];
                Response.Redirect("Index.aspx");
                //this.Response.Write("<script>location.href='list.aspx';</script>");
            }
            else
            {
                this.Response.Write("<script>alert('输入的用户名或密码错误');</script>");
            }
        }
    }
}