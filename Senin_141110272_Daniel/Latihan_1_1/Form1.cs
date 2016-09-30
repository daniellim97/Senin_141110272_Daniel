using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = vScrollBar1.Value.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = vScrollBar2.Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int nilai, hasil;
            nilai = dateTimePicker1.Value.Year;
            hasil = DateTime.Now.Year - nilai;
            label5.Text = hasil.ToString();
            if (hasil > vScrollBar1.Value && hasil < vScrollBar2.Value)
            {
                label6.Text = "Umur kamu " + hasil + " berada dalam range " + vScrollBar1.Value + " dan " + vScrollBar2.Value;
            }
            else if (nilai > DateTime.Now.Year)
                label6.Text = "Kamu belum lahir!";
            else
                label6.Text = "Pilihlah sesuai dengan dalam range!";
        }
    }
}
