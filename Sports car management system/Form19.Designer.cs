namespace Sports_car_management_system
{
    partial class Form19
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.haocheDataSet9 = new Sports_car_management_system.haocheDataSet9();
            this.caigouBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caigouTableAdapter = new Sports_car_management_system.haocheDataSet9TableAdapters.caigouTableAdapter();
            this.dinhuoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gonshangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shangpinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shuliangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riqiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fukuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beizhuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jinhuoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caigouBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dinhuoDataGridViewTextBoxColumn,
            this.gonshangDataGridViewTextBoxColumn,
            this.shangpinDataGridViewTextBoxColumn,
            this.shuliangDataGridViewTextBoxColumn,
            this.riqiDataGridViewTextBoxColumn,
            this.fukuanDataGridViewTextBoxColumn,
            this.beizhuDataGridViewTextBoxColumn,
            this.jinhuoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.caigouBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1063, 472);
            this.dataGridView1.TabIndex = 2;
            // 
            // haocheDataSet9
            // 
            this.haocheDataSet9.DataSetName = "haocheDataSet9";
            this.haocheDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // caigouBindingSource
            // 
            this.caigouBindingSource.DataMember = "caigou";
            this.caigouBindingSource.DataSource = this.haocheDataSet9;
            // 
            // caigouTableAdapter
            // 
            this.caigouTableAdapter.ClearBeforeFill = true;
            // 
            // dinhuoDataGridViewTextBoxColumn
            // 
            this.dinhuoDataGridViewTextBoxColumn.DataPropertyName = "dinhuo";
            this.dinhuoDataGridViewTextBoxColumn.HeaderText = "订货编号";
            this.dinhuoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dinhuoDataGridViewTextBoxColumn.Name = "dinhuoDataGridViewTextBoxColumn";
            this.dinhuoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dinhuoDataGridViewTextBoxColumn.Width = 125;
            // 
            // gonshangDataGridViewTextBoxColumn
            // 
            this.gonshangDataGridViewTextBoxColumn.DataPropertyName = "gonshang";
            this.gonshangDataGridViewTextBoxColumn.HeaderText = "供应商编号";
            this.gonshangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gonshangDataGridViewTextBoxColumn.Name = "gonshangDataGridViewTextBoxColumn";
            this.gonshangDataGridViewTextBoxColumn.Width = 125;
            // 
            // shangpinDataGridViewTextBoxColumn
            // 
            this.shangpinDataGridViewTextBoxColumn.DataPropertyName = "shangpin";
            this.shangpinDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.shangpinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shangpinDataGridViewTextBoxColumn.Name = "shangpinDataGridViewTextBoxColumn";
            this.shangpinDataGridViewTextBoxColumn.Width = 125;
            // 
            // shuliangDataGridViewTextBoxColumn
            // 
            this.shuliangDataGridViewTextBoxColumn.DataPropertyName = "shuliang";
            this.shuliangDataGridViewTextBoxColumn.HeaderText = "订货数量";
            this.shuliangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shuliangDataGridViewTextBoxColumn.Name = "shuliangDataGridViewTextBoxColumn";
            this.shuliangDataGridViewTextBoxColumn.Width = 125;
            // 
            // riqiDataGridViewTextBoxColumn
            // 
            this.riqiDataGridViewTextBoxColumn.DataPropertyName = "riqi";
            this.riqiDataGridViewTextBoxColumn.HeaderText = "下单日期";
            this.riqiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.riqiDataGridViewTextBoxColumn.Name = "riqiDataGridViewTextBoxColumn";
            this.riqiDataGridViewTextBoxColumn.Width = 125;
            // 
            // fukuanDataGridViewTextBoxColumn
            // 
            this.fukuanDataGridViewTextBoxColumn.DataPropertyName = "fukuan";
            this.fukuanDataGridViewTextBoxColumn.HeaderText = "付款方式";
            this.fukuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fukuanDataGridViewTextBoxColumn.Name = "fukuanDataGridViewTextBoxColumn";
            this.fukuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // beizhuDataGridViewTextBoxColumn
            // 
            this.beizhuDataGridViewTextBoxColumn.DataPropertyName = "beizhu";
            this.beizhuDataGridViewTextBoxColumn.HeaderText = "备注";
            this.beizhuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.beizhuDataGridViewTextBoxColumn.Name = "beizhuDataGridViewTextBoxColumn";
            this.beizhuDataGridViewTextBoxColumn.Width = 125;
            // 
            // jinhuoDataGridViewTextBoxColumn
            // 
            this.jinhuoDataGridViewTextBoxColumn.DataPropertyName = "jinhuo";
            this.jinhuoDataGridViewTextBoxColumn.HeaderText = "是否进货";
            this.jinhuoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jinhuoDataGridViewTextBoxColumn.Name = "jinhuoDataGridViewTextBoxColumn";
            this.jinhuoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form19";
            this.Text = "采购计划";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caigouBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private haocheDataSet9 haocheDataSet9;
        private System.Windows.Forms.BindingSource caigouBindingSource;
        private haocheDataSet9TableAdapters.caigouTableAdapter caigouTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinhuoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gonshangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shangpinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shuliangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riqiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fukuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beizhuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jinhuoDataGridViewTextBoxColumn;
    }
}