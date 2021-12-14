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
using System.Configuration;

namespace SuperMarketSales
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
        }

        // 点击“取消”按钮，则关闭窗口
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 点击“确认”按钮，则录入商品
        private void bt_Ok_Click(object sender, EventArgs e)
        {
            String id = this.tb_Id.Text.Trim();
            String name = this.tb_Name.Text.Trim();
            float price = float.Parse(this.tb_Price.Text.Trim());
            String spec = this.tb_Spec.Text.Trim();
            String remark = this.tb_Remark.Text.Trim();

            // 连接字符串，注意与实际环境保持一致
            String connStr = ConfigurationManager.ConnectionStrings["SuperMarketSales"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令
                String sqlStr = "insert into GOODS2(ID, NAME, PRICE, SPEC, REMARK) values(@id, @name, @price, @spec, @remark)";
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
                MessageBox.Show("访问数据库错误：" + exp.Message);
            }
            finally
            {
                sqlConn.Close();
            }
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {

        }

    }
}
