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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“haocheDataSet.huhu”中。您可以根据需要移动或移除它。
            this.huhuTableAdapter.Fill(this.haocheDataSet.huhu);



        }
    }
}
