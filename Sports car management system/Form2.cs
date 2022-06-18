using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports_car_management_system
{
    public partial class Form2 : Form
    {
        public static Form2 form2 = new Form2();
        Color color = new Color();
        public Form2()
        {
            InitializeComponent();
        }

        private void 供商信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            //44//
            form3.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            
        }

        private void 供商信息一览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
        }

        private void 供商信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
        }

        private void 客户信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void 客户信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.Show();
        }

        private void 客户信息一览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void 商品信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
        }

        private void 商品信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void 商品信息一览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
        }

        private void 员工信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
                form14.Show();
        }

        private void 员工信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
        }

        private void 员工信息一览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void 商品类型设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
        }

        private void 进货入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
        }

        private void 采购计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            form19.Show();
        }

        private void 销售出库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chuku chuku = new chuku();
            chuku.Show();
        }

        private void 库存盘点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kucunpd kucunpd = new kucunpd();
            kucunpd.Show();
        }

        private void 进货入库统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
            form2.BackColor = Color.Red;
        }

        private void Form2_Click(object sender, EventArgs e)
        {


        }

        private void 默认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Red  || BackColor == Color.Green || BackColor == Color.Blue)
            {
                BackColor = Color.LightGray;
            }
        }

        private void 主题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //if (BackColor == Color.Red)
          //  {
          //      BackColor = Color.Yellow;
          //  }
          //  else if (BackColor == Color.Yellow)
          //  {
          //      BackColor = Color.Green;
          //  }
          //  else
          //  {
          //      BackColor = Color.Red;
          //  }
        }

        private void 红色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.LightGray || BackColor == Color.Green || BackColor == Color.Blue)
            {
                BackColor = Color.Red;
            }
        }
        private void 绿色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Red || BackColor == Color.LightGray || BackColor == Color.Blue)
            {
                BackColor = Color.Green;
            }
        }

        private void 蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.Red || BackColor == Color.LightGray || BackColor == Color.Green)
            {
                BackColor = Color.Blue;
            }
        }
    }
}
