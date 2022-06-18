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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“haocheDataSet6.jinhuok”中。您可以根据需要移动或移除它。
            this.jinhuokTableAdapter.Fill(this.haocheDataSet6.jinhuok);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gonshang = textBox2.Text;
            string riqi = textBox6.Text;
            string huowu = textBox3.Text;
            string shuliang = textBox4.Text;
            string beizhu = textBox5.Text;
            string fukuan = comboBox2.Text;
            string jinhuo = comboBox3.Text;
            string sql = string.Format("insert into jinhuok values('{0}','{1}','{2}','{3}','{4}','{5}','[6]')", gonshang, riqi, huowu, shuliang, beizhu, fukuan,jinhuo);
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("添加成功");
                string conn = "server=.;database=haoche;uid =sa;pwd =1234";
                DataSet ds = new DataSet();

                SqlConnection cmd = new SqlConnection(conn);//iitial catalog
                string a = textBox1.Text;
                string str = string.Format("select * from jinhuok");
                SqlDataAdapter dap = new SqlDataAdapter(str, cmd);
                dap.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Close();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("添加失败");    
            }
        }
    }
}
