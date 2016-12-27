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
        classPos classPos = new classPos();
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
            command = new MySqlCommand("select * from pos.customer where ID=@ID", conn);
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
                classPos.updateData("customer",txtID, txtKode, txtNama, txtAlamat, txtTlpn, txtHp);
                showAll();
                reset();
                hilang();
                txtID.ReadOnly = false;

            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

                classPos.deleteData("customer", txtID);
                showAll();
                reset();
                hilang();
                txtID.ReadOnly = false;

            refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterHasil();
        }
    }
}
