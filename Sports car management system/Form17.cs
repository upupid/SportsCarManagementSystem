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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“haocheDataSet10.spleixing”中。您可以根据需要移动或移除它。
            this.spleixingTableAdapter.Fill(this.haocheDataSet10.spleixing);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string leixing = textBox2.Text;
            string sql = string.Format("insert spleixing values ('{0}')", leixing);
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
            string bianhao = textBox1.Text;
            string leixing = textBox2.Text;
            string str = string.Format("update spleixing set leixing='{0}' where bianhao='{1}'", leixing, bianhao);
            if (DBHelper.ExecuteNonQuery(str))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bianhao = textBox1.Text;
            string leixing = textBox2.Text;
            string stl = string.Format("delete from spleixing where bianhao='{0}'", bianhao);
            if (DBHelper.ExecuteNonQuery(stl))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
