﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmLzs f = new FrmLzs();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmShow f = new FrmShow();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTongX frm = new FrmTongX();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            this.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLL f = new FrmLL();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
