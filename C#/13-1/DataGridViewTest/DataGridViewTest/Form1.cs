using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 调整行高（只能放到最前面）
            //this.dataGridView1.RowTemplate.Height = (this.ClientRectangle.Height - this.dataGridView1.ColumnHeadersHeight) /5;
            this.dataGridView1.RowTemplate.Height = 60;
            
            // 增加5个空白行
            this.dataGridView1.Rows.Add(5);

            // 不允许用户添加新行
            this.dataGridView1.AllowUserToAddRows = false;

            // 设置课程（只能按行取数，试试按列是什么现象）
            this.dataGridView1.Rows[4].Cells[0].Value = "物联网应用系统设计与维护";
            this.dataGridView1.Rows[4].Cells[0].Style.BackColor = Color.Orange;

            this.dataGridView1.Rows[3].Cells[2].Value = "物联网应用系统设计与维护";
            this.dataGridView1.Rows[3].Cells[2].Style.BackColor = Color.Orange;

            // 文字过长时自动换行
            this.dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // 禁止编辑单元格
            this.dataGridView1.ReadOnly = true;

            // 点击标题栏时不允许排序
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)
            {
                this.dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        // 双击课程，弹出对应教室
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 4 && e.ColumnIndex == 0)
            {
                MessageBox.Show("10-306教室");
            }

            if (e.RowIndex == 3 && e.ColumnIndex == 2)
            {
                MessageBox.Show("10-309教室");
            }
        }
    }
}
