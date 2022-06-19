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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xingming = textBox1.Text;
            string bumeng = comboBox1.Text;
            string gongzi = textBox2.Text;
            string phone = textBox3.Text;
            string sex = "";
            if (radioButton1.Checked)
            {
                sex = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                sex = radioButton2.Text;
            }
            string mima = textBox4.Text;
            string zhuzhi = textBox5.Text;
            string zhiwei = textBox6.Text;
            string sql = string.Format("insert yuangong Values('{0}','{1}','{2}','{3}','{4}','{5}','[6]','{7}')", xingming, bumeng, gongzi, phone, sex, mima, zhuzhi, zhiwei);
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
