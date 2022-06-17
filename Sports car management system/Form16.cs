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
    public partial class Form16 : Form
    {
        public Form16()
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
                string sql = string.Format("select * from yuangong where xingming like '%{0}%'", a);
                SqlDataAdapter dap = new SqlDataAdapter(sql, cmd);
                dap.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Close();
                cmd.Dispose();
            }
















        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form16_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string conn = "Data Source=(local);Initial Catalog = haoche;Integrated Security=True";
            SqlConnection cmd = new SqlConnection(conn);//iitial catalog
            string sql = "select [xingming],[bumeng],[gongzi],[phone],[sex],[mima],[zhuzhi],[zhiwei] from [yuangong]";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            dap.Fill(ds);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
            cmd.Close();
            cmd.Dispose();
        }
    }
}
