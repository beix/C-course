using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗口
{
    public partial class MDI窗口示例 : Form
    {
        public MDI窗口示例()
        {
            InitializeComponent();
        }

        private void 选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild frmChild = new FormChild();
            frmChild.MdiParent = this;
            frmChild.Show();
            // 试一试frmChild.ShowDialog()看看什么效果
        }

        private void 打开toolStripButton_Click(object sender, EventArgs e)
        {
            this.打开ToolStripMenuItem_Click(sender, e);
        }
        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {  
    
        }

        private void MDI窗口示例_Load(object sender, EventArgs e)
        {

        }
    }
}
