﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sports_car_management_system
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string conn = "server=.;database=haoche;uid =sa;pwd =1234";
                DataSet ds = new DataSet();

                SqlConnection cmd = new SqlConnection(conn);//iitial catalog
                string a = textBox1.Text;
                string sql = string.Format("select * from client where name like '%{0}%'", a);
                SqlDataAdapter dap = new SqlDataAdapter(sql, cmd);
                dap.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Close();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("请输入名称");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“haocheDataSet8.client”中。您可以根据需要移动或移除它。
            this.clientTableAdapter1.Fill(this.haocheDataSet8.client);
            // TODO: 这行代码将数据加载到表“haocheDataSet7.client”中。您可以根据需要移动或移除它。
            this.clientTableAdapter.Fill(this.haocheDataSet7.client);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
