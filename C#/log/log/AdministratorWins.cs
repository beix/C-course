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
    public partial class AdministratorWins : Form
    {
        public AdministratorWins()
        {
            InitializeComponent();
        }

        private void 注销LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认注销？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Application.Restart();
            }
        }


        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                //this.Close();
                Application.Exit();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
        }

        private void 修改密码PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmendPassword admin = new AmendPassword();
            admin.Show();
            this.Hide();
        }
        // 录入商品信息
        private void 录入商品信息RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
           RecordForm recordForm = new RecordForm();
           recordForm.MdiParent = this;
           recordForm.Show();
           */
           
            Formtj formtj = new Formtj();
           // formtj.MdiParent = this;
            //formtj.Show();
            /*Fromtj fromtj = new Fromtj();
            fromtj.Show();
            this.Hide();*/
       
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about=new AboutBox1();
            about.ShowDialog();

        }
        // 修改密码
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.修改密码PToolStripMenuItem_Click(sender, e);
        }     

        // 修改用户信息
        private void 修改个人信息IToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
 

        // 录入商品信息
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.录入商品信息RToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.修改个人信息IToolStripMenuItem_Click(sender, e);
        }

        private void AdministratorWins_Load(object sender, EventArgs e)
        {

        }

    }
}
