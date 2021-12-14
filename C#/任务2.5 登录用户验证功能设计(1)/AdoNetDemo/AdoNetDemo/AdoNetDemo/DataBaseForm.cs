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

namespace AdoNetDemo
{
    public partial class DataBaseForm : Form
    {
        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {
            String connStr = "Data Source=.;Initial Catalog=SuperMarketSales;Integrated Security=True";
            SqlConnection sqlConn = new SqlConnection(connStr);

            try
            {
                // 连接数据库
                sqlConn.Open();

                // 在数据库中查询USERS表
                String sqlStr = "select * from ADMIN";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);
                SqlDataReader dr = cmd.ExecuteReader();

                // 解析数据
                while (dr.Read())
                {
                    String Id = dr["ID"].ToString();
                    String Name = dr["NAME"].ToString();
                    String Password = dr["PASSWORD"].ToString();
                    String Phone = dr["PHONE"].ToString();

                    // 注意是累加
                    this.tb_Users.Text += Id + ", " + Name + ", " + Password + ", " + Phone + "\r\n";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("数据库连接失败" + exp.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
