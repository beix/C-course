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
    public partial class ModifyForm : Form
    {
        private string goodsId = null;

        public ModifyForm(string id)
        {
            this.goodsId = id;
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            // 连接字符串，注意与实际环境保持一致
            String connStr = ConfigurationManager.ConnectionStrings["SuperMarketSales"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令发送给数据库
                String sqlStr = "select * from GOODS where ID=@id";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // SQL字符串参数赋值
                cmd.Parameters.Add(new SqlParameter("@id", this.goodsId));

                SqlDataReader dr = cmd.ExecuteReader();

                // 如果从数据库中查询到记录，则显示这些数据
                if (dr.HasRows)
                {
                    dr.Read();
                    this.tb_Id.Text = dr["ID"].ToString();
                    this.tb_Name.Text = dr["NAME"].ToString();
                    this.tb_Price.Text = dr["PRICE"].ToString();
                    this.tb_Spec.Text = dr["SPEC"].ToString();
                    this.tb_Remark.Text = dr["REMARK"].ToString();
                }
                else
                {
                    MessageBox.Show("未找到相关记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String sqlStr = "update GOODS set NAME=@name, PRICE=@price, SPEC=@spec, REMARK=@remark where ID=@id";
                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // SQL字符串参数赋值
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@price", price));
                cmd.Parameters.Add(new SqlParameter("@spec", spec));
                cmd.Parameters.Add(new SqlParameter("@remark", remark));

                // 将命令发送给数据库
                int res = cmd.ExecuteNonQuery();

                // 根据返回值判断是否修改成功
                if (res != 0)
                {
                    MessageBox.Show("商品信息修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("商品信息修改失败");
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

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
