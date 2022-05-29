using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sports_car_management_system
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;database=haoche;uid=sa;pwd=1234";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            if (textBox1.Text!=""&&textBox2.Text!="" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                int id = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                string Phone = textBox3.Text;
                string Contact = textBox4.Text;
                string mailbox = textBox5.Text;
                string Bank = textBox6.Text;
                string address = textBox7.Text;
                string sql = $"insert huhu values({id},'{name}','{Phone}','{Contact}','{mailbox}','{Bank}','{address}')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("商品录入成功", "提示");
                }
            }
            else
            {
                MessageBox.Show("请补齐信息后再添加！","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
