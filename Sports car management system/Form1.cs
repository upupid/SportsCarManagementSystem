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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            statusStrip1.BackColor= Color.Transparent;

            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text.ToString() == "管理部" && textBox1.Text!=""&&textBox2.Text!="")
            {
                string user = textBox1.Text;
                string pwd = textBox2.Text;
                string sqlstr = $"select * from guanlibu where username='{user}' and password='{pwd}'";
                SqlDataReader reader =  DBHelper.GetDataReader(sqlstr);
                if (reader.HasRows)
                {
                    MessageBox.Show("登陆成功");
                    Form2 form2 = new Form2();
                    form2.Show(); 
                }
                else
                {
                    MessageBox.Show("不存在该用户");
                }
                
            }
            if (comboBox1.Text.ToString() == "销售部" && textBox1.Text != "" && textBox2.Text != "")
            {
                string user = textBox1.Text;
                string pwd = textBox2.Text;
                string sqlstr = $"select * from xiaoshoubu where username='{user}' and password='{pwd}'";
                SqlDataReader reader = DBHelper.GetDataReader(sqlstr);
                if (reader.HasRows)
                {
                    MessageBox.Show("登陆成功");
                    Form4 form4 = new Form4();
                    form4.Show();
                }
                else
                {
                    MessageBox.Show("不存在该用户");
                }
            }
            if (comboBox1.Text.ToString() == "后勤部" && textBox1.Text != "" && textBox2.Text != "")
            {
                string user = textBox1.Text;
                string pwd = textBox2.Text;
                string sqlstr = $"select * from houqingbu where username='{user}' and password='{pwd}'";
                SqlDataReader reader = DBHelper.GetDataReader(sqlstr);
                if (reader.HasRows)
                {
                    MessageBox.Show("登陆成功");
                    Form5 form5 = new Form5();
                    form5.Show();
                }
                else
                {
                    MessageBox.Show("不存在该用户");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭程序吗","提示：",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("您选择了是");
                Application.Exit(); 
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("您选择了否");
            }
        }
    }
}
