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

namespace SuperMarketSales
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            // 固定上半部分，下半部分随窗口大小调整
            this.splitContainer1.IsSplitterFixed = false;
            this.splitContainer1.FixedPanel = FixedPanel.Panel1;
        }

        // 查询数据
        private void bt_Query_Click(object sender, EventArgs e)
        {
            // 连接字符串，注意与实际环境保持一致
            String connStr = ConfigurationManager.ConnectionStrings["SuperMarketSales"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                // 连接数据库
                sqlConn.Open();

                // 构造命令
                String sqlStr = "select * from GOODS where 1=1 ";

                // 添加查询条件
                if (!this.tb_Id.Text.Trim().Equals(""))
                {
                    sqlStr += " and ID='" + this.tb_Id.Text.Trim() + "'";
                }

                if (!this.tb_Name.Text.Trim().Equals(""))
                {
                    sqlStr += " and NAME like '%" + this.tb_Name.Text.Trim() + "%'";
                }

                SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                // 将该查询过程绑定到DataAdapter
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;

                // 将DataSet和DataAdapter绑定
                DataSet ds = new DataSet();
                // 自定义一个表(MyGoods)来标识数据库的GOODS表
                adp.Fill(ds, "MyGoods");

                // 指定DataGridView的数据源为DataSet的MyGoods表
                this.dgv_Goods.DataSource = ds.Tables["MyGoods"];
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

        // 数据修改，删除
        private void dgv_Goods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 点击修改链接
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                // 获取所要修改关联对象的主键
                string goodsId = this.dgv_Goods["Id", e.RowIndex].Value.ToString(); 
                ModifyForm modifyForm = new ModifyForm(goodsId);
                modifyForm.Show();
            }
            else if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // 获取所要删除关联对象的主键
                    string goodsId = this.dgv_Goods["Id", e.RowIndex].Value.ToString();

                    // TODO 
                    // 这里要构造删除语句，将选中的记录删除，删除字符串为 "delete from GOODS where ID=@id"
                    // 语法参考PwdForm里面的UPDATE流程
                }
            }
        }
    }
}
