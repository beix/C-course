using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log
{
    public partial class Formtj : Form
    {

        public Formtj()
        {
            InitializeComponent();
        }

        // 点击“取消”按钮，则关闭窗口
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }         

            private void Formtj_Load(object sender, EventArgs e)
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
        // 点击“确认”按钮，则录入商品
        private void button1_Click(object sender, EventArgs e)
        {
            String id = this.textBox1.Text.Trim();
            String name = this.textBox2.Text.Trim();
            float price = float.Parse(this.textBox3.Text.Trim());
            String spec = this.textBox4.Text.Trim();
            String remark = this.textBox5.Text.Trim();
            String GODE = this.comboBox1.Text.Trim();
            // 连接字符串，注意与实际环境保持一致
            String connStr = ConfigurationManager.ConnectionStrings["SuperMarketSales"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令
                String sqlStr = "insert into GOODS2(ID, NAME, PRICE, SPEC, REMARK) values(@id, @name, @price, @spec,@code,@remark) ";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);          
               

                // SQL字符串参数赋值
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@price", price));
                cmd.Parameters.Add(new SqlParameter("@spec", spec));
                cmd.Parameters.Add(new SqlParameter("@remark", remark));               
                
                // 将命令发送给数据库
                int res = cmd.ExecuteNonQuery();

                // 根据返回值判断是否插入成功
                if (res != 0)
                {
                    MessageBox.Show("商品信息录入成功");
                }
                else
                {
                    MessageBox.Show("商品信息录入失败");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("访问数据库错误：" + exp.ToString());
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

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        public object code { get; set; }
         
    }
}
