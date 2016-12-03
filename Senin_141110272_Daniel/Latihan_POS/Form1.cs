using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tambahBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahBarang formTambahBarang = new tambahBarang();
            formTambahBarang.MdiParent = this;
            formTambahBarang.Show();
        }
    }
}
