using System;
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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string conn = "server=.;database=haoche;uid =sa;pwd =1234";
                DataSet ds = new DataSet();

                SqlConnection cmd = new SqlConnection(conn);//iitial catalog
                string a = textBox2.Text;
                string sql = string.Format("select * from Productentry where name like '%{0}%'", a);
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

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
