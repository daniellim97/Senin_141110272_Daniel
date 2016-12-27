using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class tambahBarang : Form
    {
        public tambahBarang()
        {
            InitializeComponent();
        }
        private String id;
        private String kode;
        private String namaBarang;
        private String jumlahBarang;
        private String hpp;
        private String jual;
        classPos classPos = new classPos();
        DateTime time = DateTime.Now;
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=");
        string isi;
        MySqlCommand command;
        DataTable dt;
        MySqlDataAdapter da;

        void showAll()
        {
            command = new MySqlCommand("select * from barang", conn);
            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        public int count_id(string table)
        {
            string stmt = "SELECT COUNT(*) FROM " + table;
            int a;
            using (MySqlCommand cmd = new MySqlCommand(stmt, conn))
            {
                conn.Open();
                a = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return a;
            }
        }
      
        void refresh()
        {
            int id = count_id("barang") + 1;
            txtID.Text = id.ToString();
            showAll();
            reset();
            dataGridView1.ClearSelection();
        }
        
        void filterHasil()
        {
            command = new MySqlCommand("select * from pos.barang where Kode like concat('%', @Kode, '%') and Nama like concat('%', @Nama, '%')", conn);
            command.Parameters.AddWithValue("@Kode", txtKode.Text);
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        void reset()
        {
            command = new MySqlCommand("select ifnull(max(id),0)+1 from barang", conn);
            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);
            isi = dt.Rows[0][0].ToString();
            txtKode.Text = "";
            txtNama.Text = "";
            txtJumlah.Text = "";
            txtHpp.Text = "";
            txtJual.Text = "";
        }

        private void tambahBarang_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                if (txtID.Text == isi)
                {
                    classPos.insertDataBarang(txtID, txtKode, txtNama, txtJumlah, txtHpp, txtJual);
                    showAll();
                    reset();
                }
                else
                {
                    classPos.updateDataBarang(txtID,txtKode, txtNama, txtJumlah, txtHpp, txtJual);
                    showAll();
                    reset();
                }                
                refresh();       
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                kode = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                namaBarang = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                jumlahBarang = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                hpp = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                jual = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                txtID.Text = id;
                txtKode.Text = kode;
                txtNama.Text = namaBarang;
                txtJumlah.Text = jumlahBarang;
                txtHpp.Text = hpp;
                txtJual.Text = jual;
            }
            
        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKode_TextChanged_1(object sender, EventArgs e)
        {
            filterHasil();
        }
    }
}
