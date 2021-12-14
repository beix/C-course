using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log
{
    public partial class CashierWins: Form
    {
        public CashierWins()
        {
            InitializeComponent();
        }

        private void CashierWins_Load(object sender, EventArgs e)
        {
               
        }

        private void 注销LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认注销？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)== DialogResult.OK) {
                LogWins log = new LogWins();
                log.Show();
                this.Hide();
            }
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
        }

        // 修改密码
        private void 修改密码PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmendPassword amendPassword = new AmendPassword();
            amendPassword.MdiParent = this;
            amendPassword.StartPosition = FormStartPosition.CenterScreen;
            amendPassword.Show();
        }
        // 修改用户信息
        private void 修改个人信息IToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // 查询商品信息
        private void 查询商品信息SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashierCX cashierCX = new CashierCX();
            //cashierCX.MdiParent = this;
            //cashierCX.WindowState = FormWindowState.Maximized;
             cashierCX.Show();
             Hide();

        }
        // 修改密码
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.修改密码PToolStripMenuItem_Click(sender, e);
        }

        // 修改用户信息
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.修改个人信息IToolStripMenuItem_Click(sender, e);
        }

        // 查询商品信息
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.查询商品信息SToolStripMenuItem_Click(sender, e);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();

        }

    }
}
