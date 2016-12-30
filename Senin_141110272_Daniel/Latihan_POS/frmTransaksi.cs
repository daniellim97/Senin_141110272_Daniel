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
    public partial class frmTransaksi : Form
    {
        public frmTransaksi()
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

        int sisa,akhir,id;
        
        void showAll()
        {
            command = new MySqlCommand("select * from penjualan", conn);
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

        public void hilangB(){
            txtBarang.Visible = false;
            jlhBarang.Visible = false;
            totalHarga.Visible = false;
            totalHarga.ReadOnly = false;
            label3.Visible = false;
            label4.Visible = false;
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
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }
        public void munculC()
        {
            txtCust.Visible = true;
            label6.Visible = true;
            srcCust.ReadOnly = true;
            txtCust.ReadOnly = true;
        }
        public void hilangC()
        {
            txtCust.Visible = false;
            label6.Visible = false;
            srcCust.Text = "";
            srcCust.ReadOnly = false;
            
        }
        
        public void write()
        {
            srcCust.ReadOnly = false;
            txtCust.ReadOnly = false;
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
            command = new MySqlCommand("select * from pos.penjualan where id_customer like concat('%', @id, '%') ", conn);
            command.Parameters.AddWithValue("@id", srcCust.Text);
            
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
                hilangB();
            }

            conn.Close();
        }

        private void browseC_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("select * from pos.customer where ID=@id", conn);
            command.Parameters.AddWithValue("@id", srcCust.Text);
            conn.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                
                while (reader.Read())
                {

                    txtCust.Text = (reader["Nama"].ToString());

                }
                munculC();
                
                
            }
            else
            {
                MessageBox.Show("Customer Tidak di Temukan !");
            }

            conn.Close();
            filterHasil();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void jlhBarang_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void cart_Click(object sender, EventArgs e)
        {
            int skrg;
            id = count_id("penjualan") + 1;
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
                akhir = sisa - skrg;
                if (akhir < 0 )
                {
                    MessageBox.Show("Barang tidak cukup!");
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
            if (string.IsNullOrEmpty(txtCust.Text))
            {
                MessageBox.Show("Nama Customer belum diisi!");
                return;
            }

            if (string.IsNullOrEmpty(jlhBarang.Text) || jlhBarang.Text == "0")
            {
                MessageBox.Show("Jumlah Barang belum diisi atau tidak valid!");
                return;
            }


            command = new MySqlCommand("Insert into pos.penjualan(id,id_customer,id_barang,namaBarang,jlhBarang,hargaBarang,waktuJual) values(@id,@idcustomer,@idbarang,@namaBarang,@jlhBarang,@hargaBarang,@waktuJual);", conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@idcustomer", srcCust.Text);
            command.Parameters.AddWithValue("@idbarang", srcBarang.Text);
            command.Parameters.AddWithValue("@namaBarang", txtBarang.Text);
            command.Parameters.AddWithValue("@jlhBarang", Convert.ToInt16(jlhBarang.Text));
            command.Parameters.AddWithValue("@hargaBarang", Convert.ToDecimal(totalHarga.Text));
            command.Parameters.AddWithValue("@waktuJual", time);


            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Barang berhasil dijual!");

                command = new MySqlCommand("update pos.barang set JumlahAwal=@JumlahAwal where ID=@id;", conn);
                command.Parameters.AddWithValue("@JumlahAwal", akhir);
                command.Parameters.AddWithValue("@id", Convert.ToInt16(srcBarang.Text));
                


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

        private void beli_Click(object sender, EventArgs e)
        {

        }

        private void frmTransaksi_Load(object sender, EventArgs e)
        {
            write();
            hilangB();
            hilangC();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            hilangB();
            hilangC();
        }
    }
}
