using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class showorder : System.Web.UI.Page
    {
        public string operid ;
        protected void Page_Load(object sender, EventArgs e)
        {
            operid = Request.QueryString["operid"];
            operid += " " + Request.QueryString["opername"];
        }
    }
}