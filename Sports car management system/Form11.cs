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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstr = "server=.;database=haoche;uid=sa;pwd=1234";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "")
            {
                int Snumbering = int.Parse(textBox1.Text);
                int Qnameing = int.Parse(textBox6.Text);
                string Name = textBox7.Text;
                string color = textBox2.Text;
                string Jprice = textBox5.Text;
                string Xprice = textBox8.Text;
                string Xscka = textBox3.Text;
                string Dscka = textBox4.Text;
                string Yscka = textBox9.Text;
                string Introduce = textBox10.Text;
                string sql = $"insert Productentry values({Snumbering},'{Qnameing}','{Name}','{color}','{Jprice}','{Xprice}','{Xscka}','{Dscka}','{Yscka}','{Introduce}')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
