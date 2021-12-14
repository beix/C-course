using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String userName = this.tb_User.Text.Trim();
            String newPwd = this.tb_NewPwd.Text.Trim();
            String confPwd = this.tb_ConfirmPwd.Text.Trim();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
