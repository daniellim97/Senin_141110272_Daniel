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

        private void tambahCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahCustomer formTambahCust = new tambahCustomer();
            formTambahCust.MdiParent = this;
            formTambahCust.Show();
        }

        private void tambahSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahSupplier formTambahSupp = new tambahSupplier();
            formTambahSupp.MdiParent = this;
            formTambahSupp.Show();
        }

        private void editBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editBarang formEditBrg = new editBarang();
            formEditBrg.MdiParent = this;
            formEditBrg.Show();
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCustomer formEditCust = new editCustomer();
            formEditCust.MdiParent = this;
            formEditCust.Show();
        }

        private void editSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editSupplier formEditSupp = new editSupplier();
            formEditSupp.MdiParent = this;
            formEditSupp.Show();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransaksi formTransaksi = new frmTransaksi();
            formTransaksi.MdiParent = this;
            formTransaksi.Show();
        }
    }
}
