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
    public partial class tambahCustomer : Form
    {
        public tambahCustomer()
        {
            InitializeComponent();
        }
        private string id;
        private string kode;
        private string nama;
        private string alamat;
        private string telp;
        private string hp;
        classPos classPos = new classPos();
        DateTime time = DateTime.Now;
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=");
        string isi;
        MySqlCommand command;
        DataTable dt;
        MySqlDataAdapter da;

        void showAll()
        {
            command = new MySqlCommand("select * from customer", conn);
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
            int id = count_id("customer") + 1;
            txtID.Text = id.ToString();
            showAll();
            reset();
            dataGridView1.ClearSelection();
        }
        
        void filterHasil()
        {
            command = new MySqlCommand("select * from pos.customer where Kode like concat('%', @Kode, '%') and Nama like concat('%', @Nama, '%')", conn);
            command.Parameters.AddWithValue("@Kode", txtKode.Text);
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        void reset()
        {
            command = new MySqlCommand("select ifnull(max(id),0)+1 from customer", conn);
            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);
            isi = dt.Rows[0][0].ToString();
            txtKode.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtTelp.Text = "";
            txtHp.Text = "";
            txtID.Text = "";
            showAll();
            int id = count_id("customer") + 1;
            txtID.Text = id.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (txtID.Text == isi)
                {
                    classPos.insertData("customer", txtID, txtKode, txtNama, txtAlamat, txtTelp, txtHp);
                    reset();
                    showAll();
                }
                else
                {
                    classPos.updateData("customer",txtID, txtKode, txtNama, txtAlamat, txtTelp, txtHp);
                    reset();
                    showAll();
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
                nama = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                alamat = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                telp = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                hp = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                txtID.Text = id;
                txtKode.Text = kode;
                txtNama.Text = nama;
                txtAlamat.Text = alamat;
                txtTelp.Text = telp;
                txtHp.Text = hp;
            }
        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            filterHasil();
        }

        private void tambahCustomer_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
