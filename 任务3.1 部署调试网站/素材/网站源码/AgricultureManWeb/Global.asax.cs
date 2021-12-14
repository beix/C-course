using log4net;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Global));

        protected void Application_Start(object sender, EventArgs e)
        {
            try
            {
                //打开串口
                sp = new SerialPort("COM3", 9600);
                sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                sp.Open();
            }
            catch (Exception ex)
            {
                log.Error(ex.StackTrace);
            }
        }
        SerialPort sp = null;
        public static string serialPortData = "";
        protected void Session_Start(object sender, EventArgs e)
        {
            
        }

        //串口接收数据后处理函数
        private void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialPortData = sp.ReadExisting();
            log.Info("receive serialPortData=#" + serialPortData + "#");
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            
        }

        protected void Application_End(object sender, EventArgs e)
        {
            try
            {
                if (sp != null && sp.IsOpen)
                {
                    sp.Close();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.StackTrace);
            }
        }
    }
}