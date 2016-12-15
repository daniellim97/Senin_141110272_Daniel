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

        void insertData(string tabel)
        {
            if (string.IsNullOrEmpty(txtKode.Text))
            {
                MessageBox.Show("Kode Customer belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama Customer belum diisi!");
                return;
            }

            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                MessageBox.Show("Alamat Customer belum diisi!");
                return;
            }
            if ((string.IsNullOrEmpty(txtTelp.Text)) && (string.IsNullOrEmpty(txtHp.Text)))
            {
                MessageBox.Show("Mohon isi salah satu : telepon atau Hp");
                return;
            }

            command = new MySqlCommand("Insert into " + tabel + "(ID,Kode,Nama,Alamat,Telp,Hp,Created_at,Updated_at) values(@ID,@Kode,@Nama,@Alamat,@Telp,@Hp,@Created_at,@Updated_at);", conn);
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
            command.Parameters.AddWithValue("@Telp", txtTelp.Text);
            command.Parameters.AddWithValue("@Hp", txtHp.Text);
            command.Parameters.AddWithValue("@Created_at", time);
            command.Parameters.AddWithValue("@Updated_at", time);
            MessageBox.Show("Berhasil !");
            command.ExecuteNonQuery();
            reset();
            showAll();


        }
        void refresh()
        {
            int id = count_id("customer") + 1;
            txtID.Text = id.ToString();
            showAll();
            reset();
            dataGridView1.ClearSelection();
        }
        void updateData(string tabel)
        {
            if (string.IsNullOrEmpty(txtKode.Text))
            {
                MessageBox.Show("Kode Customer belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama Customer belum diisi!");
                return;
            }

            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                MessageBox.Show("Alamat Customer belum diisi!");
                return;
            }
            if ((string.IsNullOrEmpty(txtTelp.Text)) && (string.IsNullOrEmpty(txtHp.Text)))
            {
                MessageBox.Show("Mohon isi salah satu : telepon atau Hp");
                return;
            }

            command = new MySqlCommand("update " + tabel + " set Kode=@Kode,Nama=@Nama,Alamat=@Alamat,Telp=@Telp,Hp=@Hp,Updated_at=@Updated_at where Kode=@Kode", conn);
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
            command.Parameters.AddWithValue("@Telp", txtTelp.Text);
            command.Parameters.AddWithValue("@Hp", txtHp.Text);
            command.Parameters.AddWithValue("@Updated_at", time);
            command.ExecuteNonQuery();
            MessageBox.Show("Berhasil !");
            showAll();
            reset();

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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == isi)
                {
                    conn.Open();
                    insertData("customer");
                }
                else
                {
                    conn.Open();
                    updateData("customer");
                }
                conn.Close();
                
                refresh();


            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
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
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                txtID.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtKode.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txtNama.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                txtAlamat.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txtTelp.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txtHp.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();

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
