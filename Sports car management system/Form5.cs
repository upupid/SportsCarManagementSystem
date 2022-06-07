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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string conn = "Data Source=(local);Initial Catalog = haoche;Integrated Security=True";
            SqlConnection cmd = new SqlConnection(conn);//iitial catalog
            string sql = "select [Carnumber],[Knumber],[warehouse],[WarehouseNo],[Inventory] from [kucun]";
            SqlDataAdapter dap = new SqlDataAdapter(sql,conn);
            dap.Fill(ds);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
            cmd.Close();
            cmd.Dispose();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
