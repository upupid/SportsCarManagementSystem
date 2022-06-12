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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;database=haoche;uid=sa;pwd=1234";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            if (textBox1.Text != "" && textBox2.Text != ""&&button1.Text!="" && button1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                int id = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                string age = button1.Text;
                string phone = textBox3.Text;
                string unit = textBox4.Text;
                string address = textBox5.Text;
                string sql = $"insert client values({id},'{name}','{age}','{phone}','{unit}','{address}')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("商品录入成功", "提示");
                }
            }
            else
            {
                MessageBox.Show("请补齐信息后再添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Close();
        }
    }
}
