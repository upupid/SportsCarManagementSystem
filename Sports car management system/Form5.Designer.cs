namespace Sports_car_management_system
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Carnumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Knumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 322);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnumb,
            this.Knumber,
            this.warehouse,
            this.WarehouseNo,
            this.Inventory});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(600, 304);
            this.dataGridView1.TabIndex = 3;
            // 
            // Carnumb
            // 
            this.Carnumb.DataPropertyName = "Carnumber";
            this.Carnumb.HeaderText = "汽车编号";
            this.Carnumb.MinimumWidth = 6;
            this.Carnumb.Name = "Carnumb";
            this.Carnumb.Width = 125;
            // 
            // Knumber
            // 
            this.Knumber.DataPropertyName = "Knumber";
            this.Knumber.HeaderText = "库存编号";
            this.Knumber.MinimumWidth = 6;
            this.Knumber.Name = "Knumber";
            this.Knumber.Width = 125;
            // 
            // warehouse
            // 
            this.warehouse.DataPropertyName = "warehouse";
            this.warehouse.HeaderText = "仓库名称";
            this.warehouse.MinimumWidth = 6;
            this.warehouse.Name = "warehouse";
            this.warehouse.Width = 125;
            // 
            // WarehouseNo
            // 
            this.WarehouseNo.DataPropertyName = "WarehouseNo";
            this.WarehouseNo.HeaderText = "仓库编号";
            this.WarehouseNo.MinimumWidth = 6;
            this.WarehouseNo.Name = "WarehouseNo";
            this.WarehouseNo.Width = 125;
            // 
            // Inventory
            // 
            this.Inventory.DataPropertyName = "Inventory";
            this.Inventory.HeaderText = "库存数量";
            this.Inventory.MinimumWidth = 6;
            this.Inventory.Name = "Inventory";
            this.Inventory.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "库存盘点";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Knumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory;
    }
}