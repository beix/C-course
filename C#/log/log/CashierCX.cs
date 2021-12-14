﻿using System;
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
    public partial class CashierCX : Form
    {
        public CashierCX()
        {
            InitializeComponent();
        }
        private void CashiCX_Load(object sender, EventArgs e)
        {
            // 固定上半部分，下半部分随窗口大小调整
            this.splitContainer1.IsSplitterFixed = false;
            this.splitContainer1.FixedPanel = FixedPanel.Panel1;
        }

        // 查询数据
        private void button1_Click(object sender, EventArgs e)
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
                if (!this.textBox1.Text.Trim().Equals(""))
                {
                    sqlStr += " and ID='" + this.textBox1.Text.Trim() + "'";
                }

                if (!this.textBox2.Text.Trim().Equals(""))
                {
                    sqlStr += " and NAME like '%" + this.textBox2.Text.Trim() + "%'";
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
                this.dataGridView1.DataSource = ds.Tables["MyGoods"];
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 点击修改链接
            if (e.RowIndex != -1 && e.ColumnIndex == 0)
            {
                // 获取所要修改关联对象的主键
                string goodsId = this.dataGridView1["Column1", e.RowIndex].Value.ToString();
                Cashierxg cashierxg = new Cashierxg(goodsId);
                cashierxg.Show();
            }                          

            else if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // 获取所要删除关联对象的主键
                    string goodsId = this.dataGridView1["Column1", e.RowIndex].Value.ToString();

                    // 连接字符串，注意与实际环境保持一致
                    String connStr = ConfigurationManager.ConnectionStrings["SuperMarketSales"].ConnectionString;
                    SqlConnection sqlConn = new SqlConnection(connStr);
                    try
                    {
                        // 连接数据库
                        sqlConn.Open();

                        // 构造命令
                        String sqlStr = "delete from GOODS where ID=@id";
                        SqlCommand cmd = new SqlCommand(sqlStr, sqlConn);

                        // SQL字符串参数赋值
                        cmd.Parameters.Add(new SqlParameter("@id", goodsId));

                        // 将命令发送给数据库
                        int res = cmd.ExecuteNonQuery();

                        // 根据返回值判断是否修改成功
                        if (res != 0)
                        {
            
                            MessageBox.Show("删除成功");
                          
                        }
                        else
                        {
                            MessageBox.Show("删除失败");
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
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
