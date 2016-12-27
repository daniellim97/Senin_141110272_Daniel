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
        string isi;
        DataTable dt;
        MySqlDataAdapter da;
        MySqlDataReader reader = null;
        


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

        private void browseB_Click(object sender, EventArgs e)
        {
            
            command = new MySqlCommand("select * from pos.barang where Kode=@Kode", conn);
            command.Parameters.AddWithValue("@kode", srcBarang.Text);
            conn.Open();
            reader = command.ExecuteReader();
            
            if (reader.HasRows)
            {
                
                
                while (reader.Read())
                {
                    
                    txtBarang.Text = (reader["Nama"].ToString());
                    
                }

            }
            else
            {
                MessageBox.Show("Barang Tidak di Temukan !");
            }

            conn.Close();
        }

        private void browseC_Click(object sender, EventArgs e)
        {
            command = new MySqlCommand("select * from pos.customer where Kode=@Kode", conn);
            command.Parameters.AddWithValue("@kode", srcCust.Text);
            conn.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {

                
                while (reader.Read())
                {

                    txtCust.Text = (reader["Nama"].ToString());

                }

            }
            else
            {
                MessageBox.Show("Customer Tidak di Temukan !");
            }

            conn.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void jlhBarang_TextChanged(object sender, EventArgs e)
        {
            
            if (jlhBarang.TextLength > 0)
            {
                int jlh = Convert.ToInt32(jlhBarang.Text);
                command = new MySqlCommand("select * from pos.barang where Kode=@Kode", conn);
                command.Parameters.AddWithValue("@kode", srcBarang.Text);
                conn.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    
                    while (reader.Read())
                    {
                        totalHarga.Text = (jlh * Convert.ToDecimal(reader["HargaJual"])).ToString();
                    }

                }
                conn.Close(); 
            }
            else
                totalHarga.Text = "";
            
            
            
            
            
        }

        private void cart_Click(object sender, EventArgs e)
        {
            decimal total=0, kali =0;
            int id = count_id("count") + 1;
            command = new MySqlCommand("Insert into pos.penjualan(ID,kode_customer,kode_barang,namaBarang,jlhBarang,hargaBarang,waktuJual) values(@ID,@kode_customer,@kode_barang,@namaBarang,@jlhBarang,@hargaBarang,@waktuJual);", conn);
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@kode_cust", srcCust.Text.ToUpper());
            command.Parameters.AddWithValue("@kode_barang", srcBarang.Text);
            command.Parameters.AddWithValue("@namaBarang", txtBarang.Text);
            command.Parameters.AddWithValue("@jlhBarang", Convert.ToInt32(jlhBarang.Text));
            command.Parameters.AddWithValue("@hargaBarang", Convert.ToDecimal(totalHarga.Text));
            command.Parameters.AddWithValue("@waktuJual", time);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Barang Berhasil di Tambahkan!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
            kali = Convert.ToInt32(jlhBarang.Text) * Convert.ToDecimal(totalHarga.Text);
            total += kali;
            harga.Text = total.ToString();
        }

        private void beli_Click(object sender, EventArgs e)
        {
            
        }
    }
}
