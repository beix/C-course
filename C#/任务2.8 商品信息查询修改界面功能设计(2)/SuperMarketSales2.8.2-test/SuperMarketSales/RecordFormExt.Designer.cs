namespace SuperMarketSales
{
    partial class RecordFormExt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Remark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Spec = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_Supplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Remark
            // 
            this.tb_Remark.Location = new System.Drawing.Point(224, 266);
            this.tb_Remark.Multiline = true;
            this.tb_Remark.Name = "tb_Remark";
            this.tb_Remark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Remark.Size = new System.Drawing.Size(164, 106);
            this.tb_Remark.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(93, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "备注";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Spec
            // 
            this.tb_Spec.Location = new System.Drawing.Point(224, 171);
            this.tb_Spec.Name = "tb_Spec";
            this.tb_Spec.Size = new System.Drawing.Size(164, 25);
            this.tb_Spec.TabIndex = 3;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Cancel.Location = new System.Drawing.Point(345, 405);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(99, 37);
            this.bt_Cancel.TabIndex = 7;
            this.bt_Cancel.Text = "取消";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Ok
            // 
            this.bt_Ok.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_Ok.Location = new System.Drawing.Point(126, 405);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(99, 37);
            this.bt_Ok.TabIndex = 6;
            this.bt_Ok.Text = "录入";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(93, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "商品条码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(224, 127);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(164, 25);
            this.tb_Price.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(93, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "商品名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(224, 85);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(164, 25);
            this.tb_Name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(93, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "商品价格";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(224, 43);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(164, 25);
            this.tb_Id.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(93, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "商品规格";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbb_Supplier
            // 
            this.cbb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Supplier.FormattingEnabled = true;
            this.cbb_Supplier.Location = new System.Drawing.Point(224, 217);
            this.cbb_Supplier.Name = "cbb_Supplier";
            this.cbb_Supplier.Size = new System.Drawing.Size(164, 23);
            this.cbb_Supplier.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(93, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "供应商";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RecordForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 471);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbb_Supplier);
            this.Controls.Add(this.tb_Remark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Spec);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.label4);
            this.Name = "RecordForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录入商品信息";
            this.Load += new System.EventHandler(this.RecordFormExt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Remark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Spec;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_Supplier;
        private System.Windows.Forms.Label label6;
    }
}