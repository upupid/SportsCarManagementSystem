namespace Sports_car_management_system
{
    partial class Form13
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
            this.snumberingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qnumberingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsckaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsckaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ysckaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introduceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productentryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.haocheDataSet13 = new Sports_car_management_system.haocheDataSet13();
            this.productentryTableAdapter = new Sports_car_management_system.haocheDataSet13TableAdapters.ProductentryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productentryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(863, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snumberingDataGridViewTextBoxColumn,
            this.qnumberingDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.jpriceDataGridViewTextBoxColumn,
            this.xpriceDataGridViewTextBoxColumn,
            this.xsckaDataGridViewTextBoxColumn,
            this.dsckaDataGridViewTextBoxColumn,
            this.ysckaDataGridViewTextBoxColumn,
            this.introduceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productentryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 425);
            this.dataGridView1.TabIndex = 2;
            // 
            // snumberingDataGridViewTextBoxColumn
            // 
            this.snumberingDataGridViewTextBoxColumn.DataPropertyName = "Snumbering";
            this.snumberingDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.snumberingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snumberingDataGridViewTextBoxColumn.Name = "snumberingDataGridViewTextBoxColumn";
            this.snumberingDataGridViewTextBoxColumn.Width = 125;
            // 
            // qnumberingDataGridViewTextBoxColumn
            // 
            this.qnumberingDataGridViewTextBoxColumn.DataPropertyName = "Qnumbering";
            this.qnumberingDataGridViewTextBoxColumn.HeaderText = "汽车编号";
            this.qnumberingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qnumberingDataGridViewTextBoxColumn.Name = "qnumberingDataGridViewTextBoxColumn";
            this.qnumberingDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "汽车名称";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "汽车颜色";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Width = 125;
            // 
            // jpriceDataGridViewTextBoxColumn
            // 
            this.jpriceDataGridViewTextBoxColumn.DataPropertyName = "Jprice";
            this.jpriceDataGridViewTextBoxColumn.HeaderText = "进货价格";
            this.jpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jpriceDataGridViewTextBoxColumn.Name = "jpriceDataGridViewTextBoxColumn";
            this.jpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // xpriceDataGridViewTextBoxColumn
            // 
            this.xpriceDataGridViewTextBoxColumn.DataPropertyName = "Xprice";
            this.xpriceDataGridViewTextBoxColumn.HeaderText = "销售价格";
            this.xpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xpriceDataGridViewTextBoxColumn.Name = "xpriceDataGridViewTextBoxColumn";
            this.xpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // xsckaDataGridViewTextBoxColumn
            // 
            this.xsckaDataGridViewTextBoxColumn.DataPropertyName = "Xscka";
            this.xsckaDataGridViewTextBoxColumn.HeaderText = "最小库存";
            this.xsckaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xsckaDataGridViewTextBoxColumn.Name = "xsckaDataGridViewTextBoxColumn";
            this.xsckaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dsckaDataGridViewTextBoxColumn
            // 
            this.dsckaDataGridViewTextBoxColumn.DataPropertyName = "Dscka";
            this.dsckaDataGridViewTextBoxColumn.HeaderText = "最大库存";
            this.dsckaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dsckaDataGridViewTextBoxColumn.Name = "dsckaDataGridViewTextBoxColumn";
            this.dsckaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ysckaDataGridViewTextBoxColumn
            // 
            this.ysckaDataGridViewTextBoxColumn.DataPropertyName = "Yscka";
            this.ysckaDataGridViewTextBoxColumn.HeaderText = "原始库存";
            this.ysckaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ysckaDataGridViewTextBoxColumn.Name = "ysckaDataGridViewTextBoxColumn";
            this.ysckaDataGridViewTextBoxColumn.Width = 125;
            // 
            // introduceDataGridViewTextBoxColumn
            // 
            this.introduceDataGridViewTextBoxColumn.DataPropertyName = "Introduce";
            this.introduceDataGridViewTextBoxColumn.HeaderText = "介绍";
            this.introduceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.introduceDataGridViewTextBoxColumn.Name = "introduceDataGridViewTextBoxColumn";
            this.introduceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productentryBindingSource
            // 
            this.productentryBindingSource.DataMember = "Productentry";
            this.productentryBindingSource.DataSource = this.haocheDataSet13;
            // 
            // haocheDataSet13
            // 
            this.haocheDataSet13.DataSetName = "haocheDataSet13";
            this.haocheDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productentryTableAdapter
            // 
            this.productentryTableAdapter.ClearBeforeFill = true;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form13";
            this.Text = "商品信息一览";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productentryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private haocheDataSet13 haocheDataSet13;
        private System.Windows.Forms.BindingSource productentryBindingSource;
        private haocheDataSet13TableAdapters.ProductentryTableAdapter productentryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snumberingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qnumberingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsckaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsckaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ysckaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn introduceDataGridViewTextBoxColumn;
    }
}