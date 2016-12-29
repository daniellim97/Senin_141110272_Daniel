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
    public partial class frmTransaksiBeli : Form
    {
        public frmTransaksiBeli()
        {
            InitializeComponent();
        }
        classPos classPos = new classPos();
        DateTime time = DateTime.Now;
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=");
        MySqlCommand command;
        DataTable dt;
        MySqlDataAdapter da;
        MySqlDataReader reader = null;

        int sisa, akhir,id;

        void showAll()
        {
            command = new MySqlCommand("select * from pembelian", conn);
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
        
        public void hilangB()
        {
            txtBarang.Visible = false;
            jlhBarang.Visible = false;
            totalHarga.Visible = false;
            totalHarga.ReadOnly = false;
            label2.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            srcBarang.Text = "";

        }
        public void munculB()
        {
            txtBarang.Visible = true;
            jlhBarang.Visible = true;
            totalHarga.Visible = true;
            totalHarga.ReadOnly = true;
            txtBarang.ReadOnly = true;
            label2.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
        }
        public void munculS()
        {
            txtSupp.Visible = true;
            label4.Visible = true;
            srcSupp.ReadOnly = true;
            txtSupp.ReadOnly = true;
        }
        public void hilangS()
        {
            txtSupp.Visible = false;
            label4.Visible = false;
            srcSupp.Text = "";
            srcSupp.ReadOnly = false;

        }

        public void write()
        {
            srcSupp.ReadOnly = false;
            txtSupp.ReadOnly = false;
        }
        public void reset()
        {
            txtBarang.Text = "";
            srcBarang.Text = "";
            srcBarang.Text = "";
            jlhBarang.Text = "";
            totalHarga.Text = "";

        }
        void filterHasil()
        {
            command = new MySqlCommand("select * from pos.pembelian where id_supplier like concat('%', @id, '%') ", conn);
            command.Parameters.AddWithValue("@id", srcSupp.Text);

            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void browseB_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("select * from pos.barang where id=@id", conn);
            command.Parameters.AddWithValue("@id", srcBarang.Text);
            conn.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read())
                {

                    txtBarang.Text = (reader["Nama"].ToString());
                    totalHarga.Text = reader["HargaJual"].ToString();
                }
                munculB();
            }
            else
            {
                MessageBox.Show("Barang Tidak di Temukan !");
            }

            conn.Close();
        }

        private void browseS_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("select * from pos.supplier where ID=@id", conn);
            command.Parameters.AddWithValue("@id", srcSupp.Text);
            conn.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {


                while (reader.Read())
                {

                    txtSupp.Text = (reader["Nama"].ToString());

                }
                munculS();

            }
            else
            {
                MessageBox.Show("Supplier Tidak di Temukan !");
            }

            conn.Close();
            filterHasil();
        }

        private void cart_Click(object sender, EventArgs e)
        {
            int skrg;
            id = count_id("pembelian") + 1;
            command = new MySqlCommand("select * from pos.barang where id=@id", conn);
            command.Parameters.AddWithValue("@id", srcBarang.Text);
            conn.Close();
            conn.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sisa = Convert.ToInt32(reader["JumlahAwal"]);

                }
                skrg = Convert.ToInt16(jlhBarang.Text);
                akhir = sisa + skrg;
                if (akhir < 0)
                {
                    MessageBox.Show("Angka Tidak Valid!");
                    conn.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Barang Tidak di Temukan !");
                conn.Close();
            }
            conn.Close();

            if (string.IsNullOrEmpty(txtBarang.Text))
            {
                MessageBox.Show("Nama Barang belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(txtSupp.Text))
            {
                MessageBox.Show("Nama Supplier belum diisi!");
                return;
            }

            if (string.IsNullOrEmpty(jlhBarang.Text))
            {
                MessageBox.Show("Jumlah Barang belum diisi!");
                return;
            }


            command = new MySqlCommand("Insert into pos.pembelian(id,id_supplier,id_barang,namaBarang,jlhBarang,hargaBarang,waktuBeli) values(@id,@idsupplier,@idbarang,@namaBarang,@jlhBarang,@hargaBarang,@waktuBeli);", conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@idsupplier", srcSupp.Text);
            command.Parameters.AddWithValue("@idbarang", srcBarang.Text);
            command.Parameters.AddWithValue("@namaBarang", txtBarang.Text);
            command.Parameters.AddWithValue("@jlhBarang", Convert.ToInt16(jlhBarang.Text));
            command.Parameters.AddWithValue("@hargaBarang", Convert.ToDecimal(totalHarga.Text));
            command.Parameters.AddWithValue("@waktuBeli", time);


            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Barang berhasil dibeli!");
                
                command = new MySqlCommand("update pos.barang set JumlahAwal=@sisa,HargaJual=@hpp where ID=@ID;", conn);
                command.Parameters.AddWithValue("@sisa", akhir);
                command.Parameters.AddWithValue("@ID", Convert.ToInt16(srcBarang.Text));
                command.Parameters.AddWithValue("@hpp", Convert.ToDecimal(totalHarga.Text));

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception popup)
                {
                    MessageBox.Show(popup.Message);
                }
                reset();
                hilangB();
                filterHasil();
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
            reset();
            hilangB();
            filterHasil();
 
        }

        private void frmTransaksiBeli_Load(object sender, EventArgs e)
        {
            write();
            hilangB();
            hilangS();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            hilangB();
            hilangS();
        }


    }
}
