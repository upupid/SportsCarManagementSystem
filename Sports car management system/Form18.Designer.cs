namespace Sports_car_management_system
{
    partial class Form18
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.haocheDataSet6 = new Sports_car_management_system.haocheDataSet6();
            this.jinhuokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jinhuokTableAdapter = new Sports_car_management_system.haocheDataSet6TableAdapters.jinhuokTableAdapter();
            this.danhaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gongshangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riqiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huowuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shuliangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beizhuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fukuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jinhuoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jinhuokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(875, 494);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 38);
            this.button2.TabIndex = 37;
            this.button2.Text = "退 出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 36;
            this.button1.Text = "添 加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.danhaoDataGridViewTextBoxColumn,
            this.gongshangDataGridViewTextBoxColumn,
            this.riqiDataGridViewTextBoxColumn,
            this.huowuDataGridViewTextBoxColumn,
            this.shuliangDataGridViewTextBoxColumn,
            this.beizhuDataGridViewTextBoxColumn,
            this.fukuanDataGridViewTextBoxColumn,
            this.jinhuoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jinhuokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 212);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 241);
            this.dataGridView1.TabIndex = 35;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("宋体", 11F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "否",
            "是"});
            this.comboBox3.Location = new System.Drawing.Point(471, 158);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 26);
            this.comboBox3.TabIndex = 34;
            this.comboBox3.Text = "是";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(355, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "是否进货";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("宋体", 11F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "现金",
            "刷卡"});
            this.comboBox2.Location = new System.Drawing.Point(124, 152);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 26);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.Text = "刷卡";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(8, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "付款方式";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(797, 94);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(253, 25);
            this.textBox5.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(681, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "备 注";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(471, 92);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 25);
            this.textBox4.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(355, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "订货数量";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(124, 91);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 25);
            this.textBox3.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(8, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "货物编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(665, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "订货日期";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 32);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 25);
            this.textBox2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(331, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "供应商编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 25);
            this.textBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "进货单号";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(797, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(253, 25);
            this.textBox6.TabIndex = 38;
            // 
            // haocheDataSet6
            // 
            this.haocheDataSet6.DataSetName = "haocheDataSet6";
            this.haocheDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jinhuokBindingSource
            // 
            this.jinhuokBindingSource.DataMember = "jinhuok";
            this.jinhuokBindingSource.DataSource = this.haocheDataSet6;
            // 
            // jinhuokTableAdapter
            // 
            this.jinhuokTableAdapter.ClearBeforeFill = true;
            // 
            // danhaoDataGridViewTextBoxColumn
            // 
            this.danhaoDataGridViewTextBoxColumn.DataPropertyName = "danhao";
            this.danhaoDataGridViewTextBoxColumn.HeaderText = "进货单号";
            this.danhaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.danhaoDataGridViewTextBoxColumn.Name = "danhaoDataGridViewTextBoxColumn";
            this.danhaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.danhaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // gongshangDataGridViewTextBoxColumn
            // 
            this.gongshangDataGridViewTextBoxColumn.DataPropertyName = "gongshang";
            this.gongshangDataGridViewTextBoxColumn.HeaderText = "供应商编号";
            this.gongshangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gongshangDataGridViewTextBoxColumn.Name = "gongshangDataGridViewTextBoxColumn";
            this.gongshangDataGridViewTextBoxColumn.Width = 125;
            // 
            // riqiDataGridViewTextBoxColumn
            // 
            this.riqiDataGridViewTextBoxColumn.DataPropertyName = "riqi";
            this.riqiDataGridViewTextBoxColumn.HeaderText = "订货日期";
            this.riqiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.riqiDataGridViewTextBoxColumn.Name = "riqiDataGridViewTextBoxColumn";
            this.riqiDataGridViewTextBoxColumn.Width = 125;
            // 
            // huowuDataGridViewTextBoxColumn
            // 
            this.huowuDataGridViewTextBoxColumn.DataPropertyName = "huowu";
            this.huowuDataGridViewTextBoxColumn.HeaderText = "货物编号";
            this.huowuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.huowuDataGridViewTextBoxColumn.Name = "huowuDataGridViewTextBoxColumn";
            this.huowuDataGridViewTextBoxColumn.Width = 125;
            // 
            // shuliangDataGridViewTextBoxColumn
            // 
            this.shuliangDataGridViewTextBoxColumn.DataPropertyName = "shuliang";
            this.shuliangDataGridViewTextBoxColumn.HeaderText = "订货数量";
            this.shuliangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shuliangDataGridViewTextBoxColumn.Name = "shuliangDataGridViewTextBoxColumn";
            this.shuliangDataGridViewTextBoxColumn.Width = 125;
            // 
            // beizhuDataGridViewTextBoxColumn
            // 
            this.beizhuDataGridViewTextBoxColumn.DataPropertyName = "beizhu";
            this.beizhuDataGridViewTextBoxColumn.HeaderText = "备注";
            this.beizhuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beizhuDataGridViewTextBoxColumn.Name = "beizhuDataGridViewTextBoxColumn";
            this.beizhuDataGridViewTextBoxColumn.Width = 125;
            // 
            // fukuanDataGridViewTextBoxColumn
            // 
            this.fukuanDataGridViewTextBoxColumn.DataPropertyName = "fukuan";
            this.fukuanDataGridViewTextBoxColumn.HeaderText = "付款方式";
            this.fukuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fukuanDataGridViewTextBoxColumn.Name = "fukuanDataGridViewTextBoxColumn";
            this.fukuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // jinhuoDataGridViewTextBoxColumn
            // 
            this.jinhuoDataGridViewTextBoxColumn.DataPropertyName = "jinhuo";
            this.jinhuoDataGridViewTextBoxColumn.HeaderText = "是否进货";
            this.jinhuoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jinhuoDataGridViewTextBoxColumn.Name = "jinhuoDataGridViewTextBoxColumn";
            this.jinhuoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form18";
            this.Text = "进货入库";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jinhuokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private haocheDataSet6 haocheDataSet6;
        private System.Windows.Forms.BindingSource jinhuokBindingSource;
        private haocheDataSet6TableAdapters.jinhuokTableAdapter jinhuokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gongshangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riqiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huowuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shuliangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beizhuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fukuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jinhuoDataGridViewTextBoxColumn;
    }
}