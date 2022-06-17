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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string conn = "server=.;database=haoche;uid =sa;pwd =1234";
                DataSet ds = new DataSet();

                SqlConnection cmd = new SqlConnection(conn);//iitial catalog
                string a = textBox2.Text;
                string sql = string.Format("select * from Productentry where name like '%{0}%'", a);
                SqlDataAdapter dap = new SqlDataAdapter(sql, cmd);
                dap.Fill(ds);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];
                cmd.Close();
                cmd.Dispose();
            }
            else
            {
                MessageBox.Show("请输入名称");
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.ToString();
            string color = dataGridView1.ToString();
            string sql = string.Format("Update Productentry set Qnumbering='43',Name='小明',color='瑟夫',Jprice='24',Xprice='234',Xscka='3234',Dscka='324',Yscka='324',Introduce='阿发' where Name={0},color={1}",Name,color );
            if (DBHelper.ExecuteNonQuery(sql))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}
