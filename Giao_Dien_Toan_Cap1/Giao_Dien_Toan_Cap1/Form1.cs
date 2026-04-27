using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_Dien_Toan_Cap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtBatDai_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            int capDo = 1;

            if (rad1.Checked) capDo = 1;
            else if (rad2.Checked) capDo = 2;
            else if (rad3.Checked) capDo = 3;
            else if (rad4.Checked) capDo = 4;
            else if (rad5.Checked) capDo = 5;

            Form2 f = new Form2(ten, capDo, this);
            f.Show();
            this.Hide();
        }
    }
}
