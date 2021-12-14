using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Index));

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.ToLongTimeString();

            string data = Global.serialPortData;
            log.Info("return serialPortData=#" + data + "#");
            Label1.Text = data;
           // txtRec.Text += data + "=1\r\n";
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            //温度
            string data = Global.serialPortData;
            log.Info("return serialPortData=#" + data + "#");
            LabTemp.Text = data;
            txtRec.Text += data + "=1\r\n";
        }
    }
}