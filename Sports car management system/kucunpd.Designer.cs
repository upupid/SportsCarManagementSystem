﻿namespace Sports_car_management_system
{
    partial class kucunpd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuncunpdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.haocheDataSet2 = new Sports_car_management_system.haocheDataSet2();
            this.退出 = new System.Windows.Forms.Button();
            this.kuncunpdTableAdapter = new Sports_car_management_system.haocheDataSet2TableAdapters.kuncunpdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuncunpdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnumberDataGridViewTextBoxColumn,
            this.innumberDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.warehouseNoDataGridViewTextBoxColumn,
            this.inquantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kuncunpdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(602, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // carnumberDataGridViewTextBoxColumn
            // 
            this.carnumberDataGridViewTextBoxColumn.DataPropertyName = "Carnumber";
            this.carnumberDataGridViewTextBoxColumn.HeaderText = "汽车编号";
            this.carnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carnumberDataGridViewTextBoxColumn.Name = "carnumberDataGridViewTextBoxColumn";
            this.carnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // innumberDataGridViewTextBoxColumn
            // 
            this.innumberDataGridViewTextBoxColumn.DataPropertyName = "Innumber";
            this.innumberDataGridViewTextBoxColumn.HeaderText = "库存编号";
            this.innumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.innumberDataGridViewTextBoxColumn.Name = "innumberDataGridViewTextBoxColumn";
            this.innumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "Warehouse";
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "仓库名称";
            this.warehouseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            this.warehouseDataGridViewTextBoxColumn.Width = 125;
            // 
            // warehouseNoDataGridViewTextBoxColumn
            // 
            this.warehouseNoDataGridViewTextBoxColumn.DataPropertyName = "WarehouseNo";
            this.warehouseNoDataGridViewTextBoxColumn.HeaderText = "仓库编号";
            this.warehouseNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warehouseNoDataGridViewTextBoxColumn.Name = "warehouseNoDataGridViewTextBoxColumn";
            this.warehouseNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // inquantityDataGridViewTextBoxColumn
            // 
            this.inquantityDataGridViewTextBoxColumn.DataPropertyName = "Inquantity";
            this.inquantityDataGridViewTextBoxColumn.HeaderText = "库存数量";
            this.inquantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inquantityDataGridViewTextBoxColumn.Name = "inquantityDataGridViewTextBoxColumn";
            this.inquantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // kuncunpdBindingSource
            // 
            this.kuncunpdBindingSource.DataMember = "kuncunpd";
            this.kuncunpdBindingSource.DataSource = this.haocheDataSet2;
            // 
            // haocheDataSet2
            // 
            this.haocheDataSet2.DataSetName = "haocheDataSet2";
            this.haocheDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 退出
            // 
            this.退出.Location = new System.Drawing.Point(460, 314);
            this.退出.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.退出.Name = "退出";
            this.退出.Size = new System.Drawing.Size(56, 18);
            this.退出.TabIndex = 1;
            this.退出.Text = "退出";
            this.退出.UseVisualStyleBackColor = true;
            this.退出.Click += new System.EventHandler(this.退出_Click);
            // 
            // kuncunpdTableAdapter
            // 
            this.kuncunpdTableAdapter.ClearBeforeFill = true;
            // 
            // kucunpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 360);
            this.Controls.Add(this.退出);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "kucunpd";
            this.Text = "kucunpd";
            this.Load += new System.EventHandler(this.kucunpd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuncunpdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 退出;
        private haocheDataSet2 haocheDataSet2;
        private System.Windows.Forms.BindingSource kuncunpdBindingSource;
        private haocheDataSet2TableAdapters.kuncunpdTableAdapter kuncunpdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inquantityDataGridViewTextBoxColumn;
    }
}