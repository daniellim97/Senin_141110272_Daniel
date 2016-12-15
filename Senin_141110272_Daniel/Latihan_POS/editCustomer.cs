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
    public partial class editCustomer : Form
    {
        public editCustomer()
        {
            InitializeComponent();
        }
        DateTime time = DateTime.Now;
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=");
        MySqlCommand command;
        string isi;
        DataTable dt;
        MySqlDataAdapter da;
        MySqlDataReader reader = null;

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
            if ((string.IsNullOrEmpty(txtTlpn.Text)) && (string.IsNullOrEmpty(txtHp.Text)))
            {
                MessageBox.Show("Mohon isi salah satu : telepon atau Hp");
                return;
            }
            command = new MySqlCommand("update " + tabel + " set Kode=@Kode,Nama=@Nama,Alamat=@Alamat,Telp=@Telp,Hp=@Hp,Updated_at=@Updated_at where Kode=@Kode", conn);
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
            command.Parameters.AddWithValue("@Telp", txtTlpn.Text);
            command.Parameters.AddWithValue("@Hp", txtHp.Text);
            command.Parameters.AddWithValue("@Updated_at", time);
            command.ExecuteNonQuery();
            MessageBox.Show("Berhasil di Update !");
            showAll();
            reset();

        }
        void deleteData(string tabel)
        {
            command = new MySqlCommand("delete from " + tabel + " where ID=@ID", conn);
            command.Parameters.AddWithValue("@ID", Convert.ToInt16(txtID.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Berhasil di Hapus!");
            showAll();
            reset();
        }
        void filterHasil()
        {
            command = new MySqlCommand("select * from pos.customer where Kode like concat('%', @Kode, '%') ", conn);
            command.Parameters.AddWithValue("@Kode", txtSrc.Text);
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
            txtTlpn.Text = "";
            txtHp.Text = "";
        }
        void muncul()
        {
            txtNama.Visible = true;
            txtKode.Visible = true;
            txtAlamat.Visible = true;
            txtTlpn.Visible = true;
            txtHp.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnCancel.Visible = true;

        }
        void hilang()
        {
            txtNama.Visible = false;
            txtKode.Visible = false;
            txtAlamat.Visible = false;
            txtTlpn.Visible = false;
            txtHp.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnCancel.Visible = false;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("select * from customer where ID=@ID", conn);
            command.Parameters.AddWithValue("@ID", txtID.Text);
            conn.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                muncul();
                txtID.ReadOnly = true;
                while (reader.Read())
                {
                    txtKode.Text = (reader["Kode"].ToString());
                    txtNama.Text = (reader["Nama"].ToString());
                    txtAlamat.Text = (reader["Alamat"].ToString());
                    txtTlpn.Text = (reader["Telp"].ToString());
                    txtHp.Text = (reader["Hp"].ToString());
                }

            }
            else
            {
                MessageBox.Show("Customer Tidak di Temukan !");
            }


            conn.Close();
        }

        private void editCustomer_Load(object sender, EventArgs e)
        {
            hilang();
            refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            hilang();
            txtID.ReadOnly = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                updateData("customer");
                hilang();
                txtID.ReadOnly = false;
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }

            conn.Close();
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                deleteData("customer");
                hilang();
                txtID.ReadOnly = false;
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }

            conn.Close();
            refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterHasil();
        }
    }
}
