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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string age = "";
            if (radioButton1.Checked)
            {
                age = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                age = radioButton2.Text;
            }
            string phone = textBox3.Text;
            string unit = textBox4.Text;
            string address = textBox5.Text;
            string sql = string.Format("update client set id='{0}', age='{1}',phone='{2}',unit='{3}',address='{4}' where name='{5}'", id,age,phone,unit,address,name);
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("修改成功~");

            }
            else
            {
                MessageBox.Show("修改失败！请及时联系管理员");
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“haocheDataSet3.client”中。您可以根据需要移动或移除它。
            this.clientTableAdapter.Fill(this.haocheDataSet3.client);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string sql = string.Format("delete from client  where name='{0}'", name);
            if (DBHelper.ExecuteNonQuery(sql))
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
