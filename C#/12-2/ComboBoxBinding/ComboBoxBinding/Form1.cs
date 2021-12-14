using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ComboBoxBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String connStr = ConfigurationManager.ConnectionStrings["SuperMarketSales"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造查询命令
                String sqlStr = "select * from SUPPLIER order by CODE";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // 将该查询过程绑定到DataAdapter
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;

                // 将DataSet和DataAdapter绑定
                DataSet ds = new DataSet();
                // 自定义一个表(MySupplier)来标识数据库的SUPPLIER表
                adp.Fill(ds, "MySupplier");

                // 指定ComboBox的数据源为DataSet的MySupplier表
                this.comboBox1.DataSource = ds.Tables["MySupplier"];
                this.comboBox1.DisplayMember = "NAME"; // ComboBox下拉列表显示的内容，这里显示供应商名称
                this.comboBox1.ValueMember = "CODE";   // ComboBox另外还携带一个隐藏的值叫ValueMember，指定为供应商代码
                this.comboBox1.SelectedIndex = 0;
            }
            catch (Exception exp)
            {
                MessageBox.Show("访问数据库错误：" + exp.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.Text.ToString() + ", " + this.comboBox1.SelectedValue.ToString());
        }
    }
}
