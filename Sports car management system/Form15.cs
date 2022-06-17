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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xingmin = textBox1.Text;
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
            string sql = string.Format("update yuangong set bumeng='{0}',gongzi='{1}',phone='{2}',sex='{3}',mima='{4}',zhuzhi='{5}',zhiwei='{6}' where xingming='{7}'", bumeng, gongzi, phone, sex, mima, zhuzhi, zhiwei, xingmin);
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("修改成功~");

            }
            else
            {
                MessageBox.Show("修改失败！请及时联系管理员");
            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“haocheDataSet5.yuangong”中。您可以根据需要移动或移除它。
            this.yuangongTableAdapter.Fill(this.haocheDataSet5.yuangong);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xingmin = textBox1.Text;
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
            string sql = string.Format("delete from yuangong  where xingming='{0}'", xingmin);
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
