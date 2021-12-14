using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplication1
{
    public partial class list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginuser"] != null)
            {
                if (!Page.IsPostBack) 
                {
                    //初始状态
                    //ViewState["where"] = strwhere();
                    BindData(1); 
                }
                else 
                {
                    //回发状态 
                } 
            } else 
            { 
                //登录失败，回到登录页面
                Response.Redirect("./login.aspx");
            }
        }

        /// <summary> 
        /// 数据绑定 
        /// </summary> 
        /// <param name="pageIndex"></param> 
        private void BindData(int pageIndex) 
        {
            string str = ConfigurationManager.ConnectionStrings["NetConnectionString"].ConnectionString;
             //   ConfigurationManager.AppSettings["name"].
            SqlConnection con = new SqlConnection(str);
            con.Open();

            string sql = "select * from operator";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds , "operator");

            this.repList.DataSource = ds; 
            this.repList.DataBind();
            
        }

        

/// </summary>
/// /// <param name="source"></param>
/// /// <param name="e"></param> 
protected void repList_ItemCommand(object source, RepeaterCommandEventArgs e) { }
    }
}