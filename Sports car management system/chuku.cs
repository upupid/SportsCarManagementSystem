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
    public partial class chuku : Form
    {
        public chuku()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xiaoshou = textBox1.Text;
            string guke = textBox2.Text;
            string caozuo = comboBox1.Text;
            string jine = textBox3.Text;
            string riqi = textBox4.Text;
            string didian = textBox5.Text;
            string wancheng = comboBox2.Text;
            string fufei = comboBox3.Text;
            string beizhu = textBox6.Text;
            string str = string.Format("insert chuku Values('{0}','{1}','{2}','{3}','{4}','{5}','[6]','{7}','{8}')", xiaoshou, guke, caozuo, jine, riqi, didian, wancheng, fufei, beizhu);
            if (DBHelper.ExecuteNonQuery(str))
            {
                MessageBox.Show("添加成功");
                DataSet ds = new DataSet();
                string conn = "Data Source=(local);Initial Catalog=haoche;Integrated Security=True;";
                SqlConnection conn2 = new SqlConnection(conn);
                string sql = "select [xiaoshoud],[gukebianh],[caozuo],[bendan],[xiaoshouriqi],[jiaohuodi],[wancheng],[fufei],[beizhu] from [chuku]";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn2);
                adapter.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                conn2.Close();
                conn2.Dispose();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void chuku_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string conn = "Data Source=(local);Initial Catalog=haoche;Integrated Security=True;";
            SqlConnection conn2 = new SqlConnection(conn);
            string sql = "select [xiaoshoud],[gukebianh],[caozuo],[bendan],[xiaoshouriqi],[jiaohuodi],[wancheng],[fufei],[beizhu] from [chuku]";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn2);
            adapter.Fill(ds);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds.Tables[0];
            conn2.Close();
            conn2.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
