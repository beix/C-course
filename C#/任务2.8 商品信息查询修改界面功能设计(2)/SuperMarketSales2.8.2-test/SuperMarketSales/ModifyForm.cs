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
            // TODO
            // 窗口启动时，从数据库加载数据，以便显示给定ID的商品信息
            // 处理流程参考LoginForm里面的SELECT流程
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            // TODO
            // 点击修改按钮，则更新商品信息
            // 需要构造UPDATE语句："update GOODS set NAME=@name, PRICE=@price, SPEC=@spec, REMARK=@remark where ID=@id"
            // 处理流程参考RecordForm里面的INSERT流程
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
