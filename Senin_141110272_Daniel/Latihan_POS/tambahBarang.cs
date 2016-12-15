﻿using System;
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

        void insertData(string tabel)
        {
            if (string.IsNullOrEmpty(txtKode.Text))
            {
                MessageBox.Show("Kode barang belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama barang belum diisi!");
                return;
            }
            
            if (Convert.ToDecimal(txtHpp.Text)<=0)
            {
                MessageBox.Show("Harga masuk tidak valid !");
                return;
            }
            if (Convert.ToDecimal(txtJual.Text) <= 0)
            {
                MessageBox.Show("Harga jual tidak valid !");
                return;
            }
            command = new MySqlCommand("Insert into " + tabel + "(ID,Kode,Nama,JumlahAwal,HargaHPP,HargaJual,Created_at,Updated_at) values(@ID,@Kode,@Nama,@JumlahAwal,@HargaHPP,@HargaJual,@Created_at,@Updated_at);", conn);
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@JumlahAwal", Convert.ToInt32(txtJumlah.Text));
            command.Parameters.AddWithValue("@HargaHPP", Convert.ToDecimal(txtHpp.Text));
            command.Parameters.AddWithValue("@HargaJual", Convert.ToDecimal(txtJual.Text));
            command.Parameters.AddWithValue("@Created_at", time);
            command.Parameters.AddWithValue("@Updated_at", time);
            command.ExecuteNonQuery();
            MessageBox.Show("Berhasil !");
            reset();
            showAll();
            
            
        }
        void refresh()
        {
            int id = count_id("barang") + 1;
            txtID.Text = id.ToString();
            showAll();
            reset();
            dataGridView1.ClearSelection();
        }
        void updateData(string tabel)
        {
            if (string.IsNullOrEmpty(txtKode.Text))
            {
                MessageBox.Show("Kode barang belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama barang belum diisi!");
                return;
            }

            if (Convert.ToDecimal(txtHpp.Text) <= 0)
            {
                MessageBox.Show("Harga masuk tidak valid !");
                return;
            }
            if (Convert.ToDecimal(txtJual.Text) <= 0)
            {
                MessageBox.Show("Harga jual tidak valid !");
                return;
            }
            command = new MySqlCommand("update "+tabel+" set Kode=@Kode,Nama=@Nama,JumlahAwal=@JumlahAwal,HargaHPP=@HargaHPP,HargaJual=@HargaJual,Updated_at=@Updated_at where Kode=@Kode", conn);
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@JumlahAwal", Convert.ToInt32(txtJumlah.Text));
            command.Parameters.AddWithValue("@HargaHPP", Convert.ToDecimal(txtHpp.Text));
            command.Parameters.AddWithValue("@HargaJual", Convert.ToDecimal(txtJual.Text));
            
            command.Parameters.AddWithValue("@Updated_at", time);
            command.ExecuteNonQuery();
            MessageBox.Show("Berhasil !");
            showAll();
            reset();
            
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
            
            try
            {
                if (txtID.Text == isi)
                {
                    conn.Open();
                    insertData("barang");
                }
                else
                {
                    conn.Open();
                    updateData("barang");
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
                txtJumlah.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                txtHpp.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txtJual.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                
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
