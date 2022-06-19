namespace Sports_car_management_system
{
    partial class Form7
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
            this.huhuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.haocheDataSet1 = new Sports_car_management_system.haocheDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.huhuTableAdapter = new Sports_car_management_system.haocheDataSet1TableAdapters.huhuTableAdapter();
            this.haocheDataSet2 = new Sports_car_management_system.haocheDataSet();
            this.haocheDataSet4 = new Sports_car_management_system.haocheDataSet4();
            this.guanlibuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guanlibuTableAdapter = new Sports_car_management_system.haocheDataSet4TableAdapters.guanlibuTableAdapter();
            this.haocheDataSet11 = new Sports_car_management_system.haocheDataSet11();
            this.huhuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.huhuTableAdapter1 = new Sports_car_management_system.haocheDataSet11TableAdapters.huhuTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comtact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huhuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guanlibuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huhuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name,
            this.phone,
            this.Comtact,
            this.mailbox,
            this.Bank,
            this.address});
            this.dataGridView1.DataSource = this.huhuBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // huhuBindingSource
            // 
            this.huhuBindingSource.DataMember = "huhu";
            this.huhuBindingSource.DataSource = this.haocheDataSet1;
            // 
            // haocheDataSet1
            // 
            this.haocheDataSet1.DataSetName = "haocheDataSet1";
            this.haocheDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(413, 142);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(11, 10);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 506);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // huhuTableAdapter
            // 
            this.huhuTableAdapter.ClearBeforeFill = true;
            // 
            // haocheDataSet2
            // 
            this.haocheDataSet2.DataSetName = "haocheDataSet";
            this.haocheDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // haocheDataSet4
            // 
            this.haocheDataSet4.DataSetName = "haocheDataSet4";
            this.haocheDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guanlibuBindingSource
            // 
            this.guanlibuBindingSource.DataMember = "guanlibu";
            this.guanlibuBindingSource.DataSource = this.haocheDataSet4;
            // 
            // guanlibuTableAdapter
            // 
            this.guanlibuTableAdapter.ClearBeforeFill = true;
            // 
            // haocheDataSet11
            // 
            this.haocheDataSet11.DataSetName = "haocheDataSet11";
            this.haocheDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // huhuBindingSource1
            // 
            this.huhuBindingSource1.DataMember = "huhu";
            this.huhuBindingSource1.DataSource = this.haocheDataSet11;
            // 
            // huhuTableAdapter1
            // 
            this.huhuTableAdapter1.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "供货商编号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "供货商名称";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "手机号码";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 125;
            // 
            // Comtact
            // 
            this.Comtact.DataPropertyName = "Comtact";
            this.Comtact.HeaderText = "联系人";
            this.Comtact.MinimumWidth = 6;
            this.Comtact.Name = "Comtact";
            this.Comtact.Width = 125;
            // 
            // mailbox
            // 
            this.mailbox.DataPropertyName = "mailbox";
            this.mailbox.HeaderText = "邮箱";
            this.mailbox.MinimumWidth = 6;
            this.mailbox.Name = "mailbox";
            this.mailbox.Width = 125;
            // 
            // Bank
            // 
            this.Bank.DataPropertyName = "Bank";
            this.Bank.HeaderText = "银行账户";
            this.Bank.MinimumWidth = 6;
            this.Bank.Name = "Bank";
            this.Bank.Width = 125;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "地址";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form7";
            this.Text = "供商信息一览";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huhuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guanlibuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.haocheDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huhuBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private haocheDataSet1 haocheDataSet1;
        private System.Windows.Forms.BindingSource huhuBindingSource;
        private haocheDataSet1TableAdapters.huhuTableAdapter huhuTableAdapter;
        private haocheDataSet haocheDataSet2;
        private haocheDataSet4 haocheDataSet4;
        private System.Windows.Forms.BindingSource guanlibuBindingSource;
        private haocheDataSet4TableAdapters.guanlibuTableAdapter guanlibuTableAdapter;
        private haocheDataSet11 haocheDataSet11;
        private System.Windows.Forms.BindingSource huhuBindingSource1;
        private haocheDataSet11TableAdapters.huhuTableAdapter huhuTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comtact;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}