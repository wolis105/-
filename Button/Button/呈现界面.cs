using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.label2.Text = "";
            this.label1.Text = "点进来的是猪哦！";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.label1.Text = "";
            this.label2.Text = "是因为不敢承认而退出的吗？？？？？？";
        }
    }
}
