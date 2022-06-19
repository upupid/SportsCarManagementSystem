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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“haocheDataSet12.huhu”中。您可以根据需要移动或移除它。
            this.huhuTableAdapter1.Fill(this.haocheDataSet12.huhu);
            // TODO: 这行代码将数据加载到表“haocheDataSet.huhu”中。您可以根据需要移动或移除它。
            //his.huhuTableAdapter.Fill(this.haocheDataSet.huhu);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DataSet ds = new DataSet();
                string conn = "Data Source=(local);Initial Catalog = haoche;Integrated Security=True";
                SqlConnection cmd = new SqlConnection(conn);//iitial catalog
                string id = textBox1.Text;
                string sql = string.Format("select * from huhu where id ={0}", id);
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Close();
                cmd.Dispose();
            }
            else if (textBox2.Text != "" && textBox3.Text != "")
            {
                string name = textBox2.Text;
                string phone = textBox3.Text;
                DataSet ds = new DataSet();
                string conn = "Data Source=(local);Initial Catalog = haoche;Integrated Security=True";
                SqlConnection cmd = new SqlConnection(conn);//iitial catalog
                string sql = string.Format("select * from huhu where name ='{0}' and Phone='{1}'", name,phone);
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Close();
                cmd.Dispose();

            }
            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                string id = textBox1.Text;
                string name = textBox2.Text;
                string phone = textBox3.Text;
                DataSet ds = new DataSet();
                string conn = "Data Source=(local);Initial Catalog = haoche;Integrated Security=True";
                SqlConnection cmd = new SqlConnection(conn);//iitial catalog
                string sql = string.Format("select * from huhu where where id ={0} and name ='{1}' and Phone='{2}'", id, name, phone);
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Close();
                cmd.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string phone = textBox3.Text;
            string Comtact = textBox4.Text;
            string mailbox = textBox5.Text;
            string Bank = textBox6.Text;
            string address = textBox7.Text;
            string sll = string.Format("delete from huhu where id='{0}'", id);
            if (DBHelper.ExecuteNonQuery(sll))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
