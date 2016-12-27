using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Latihan_POS
{
    class classPos
    {
        MySqlCommand command;
        MySqlConnection conn;
        
        public classPos()
        {
            connection();
        }

        public void connection()
        {
            conn = new MySqlConnection("server=127.0.0.1;database=pos;Uid=root;Pwd=");
        }

        

        public void insertDataBarang(TextBox txtID, TextBox txtKode, TextBox txtNama, MaskedTextBox txtJumlah, TextBox txtHpp, TextBox txtJual)
        {
            DateTime time = DateTime.Now;
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
            command = new MySqlCommand("Insert into pos.barang(ID,Kode,Nama,JumlahAwal,HargaHPP,HargaJual,Created_at,Updated_at) values(@ID,@Kode,@Nama,@JumlahAwal,@HargaHPP,@HargaJual,@Created_at,@Updated_at);", conn);
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@JumlahAwal", Convert.ToInt32(txtJumlah.Text));
            command.Parameters.AddWithValue("@HargaHPP", Convert.ToDecimal(txtHpp.Text));
            command.Parameters.AddWithValue("@HargaJual", Convert.ToDecimal(txtJual.Text));
            command.Parameters.AddWithValue("@Created_at", time);
            command.Parameters.AddWithValue("@Updated_at", time);

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
        }

        public void insertData(string table,TextBox txtID, TextBox txtKode, TextBox txtNama, TextBox txtAlamat, TextBox txtTelp, TextBox txtHp)
        {
            DateTime time = DateTime.Now;
            if (string.IsNullOrEmpty(txtKode.Text))
            {
                MessageBox.Show("Kode "+ table +" belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama " + table + " belum diisi!");
                return;
            }

            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                MessageBox.Show("Alamat " + table + " belum diisi!");
                return;
            }
            if ((string.IsNullOrEmpty(txtTelp.Text)) && (string.IsNullOrEmpty(txtHp.Text)))
            {
                MessageBox.Show("Mohon isi salah satu : telepon atau Hp");
                return;
            }

            command = new MySqlCommand("Insert into " + table + "(ID,Kode,Nama,Alamat,Telp,Hp,Created_at,Updated_at) values(@ID,@Kode,@Nama,@Alamat,@Telp,@Hp,@Created_at,@Updated_at);", conn);
            command.Parameters.AddWithValue("@ID", txtID.Text);
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
            command.Parameters.AddWithValue("@Telp", txtTelp.Text);
            command.Parameters.AddWithValue("@Hp", txtHp.Text);
            command.Parameters.AddWithValue("@Created_at", time);
            command.Parameters.AddWithValue("@Updated_at", time);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("" + table + " berhasil ditambahkan!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }

        public void updateDataBarang(TextBox txtID, TextBox txtKode, TextBox txtNama, MaskedTextBox txtJumlah, TextBox txtHpp, TextBox txtJual)
        {
            DateTime time = DateTime.Now;
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
            command = new MySqlCommand("update pos.barang set ID=@ID,Kode=@Kode,Nama=@Nama,JumlahAwal=@JumlahAwal,HargaHPP=@HargaHPP,HargaJual=@HargaJual,Updated_at=@Updated_at where ID=@ID", conn);
            command.Parameters.AddWithValue("@ID", Convert.ToInt16(txtID.Text));
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@JumlahAwal", Convert.ToInt32(txtJumlah.Text));
            command.Parameters.AddWithValue("@HargaHPP", Convert.ToDecimal(txtHpp.Text));
            command.Parameters.AddWithValue("@HargaJual", Convert.ToDecimal(txtJual.Text));

            command.Parameters.AddWithValue("@Updated_at", time);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Barang Berhasil di Update!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }
        public void updateData(string table,TextBox txtID, TextBox txtKode, TextBox txtNama, TextBox txtAlamat, TextBox txtTelp, TextBox txtHp)
        {
            DateTime time = DateTime.Now;
            if (string.IsNullOrEmpty(txtKode.Text))
            {
                MessageBox.Show("Kode " + table + " belum diisi!");
                return;
            }
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama " + table + " belum diisi!");
                return;
            }

            if (string.IsNullOrEmpty(txtAlamat.Text))
            {
                MessageBox.Show("Alamat " + table + " belum diisi!");
                return;
            }
            if ((string.IsNullOrEmpty(txtTelp.Text)) && (string.IsNullOrEmpty(txtHp.Text)))
            {
                MessageBox.Show("Mohon isi salah satu : telepon atau Hp");
                return;
            }
            command = new MySqlCommand("update " + table + " set ID=@ID,Kode=@Kode,Nama=@Nama,Alamat=@Alamat,Telp=@Telp,Hp=@Hp,Updated_at=@Updated_at where ID=@ID", conn);
            command.Parameters.AddWithValue("@ID", Convert.ToInt16(txtID.Text));
            command.Parameters.AddWithValue("@Kode", txtKode.Text.ToUpper());
            command.Parameters.AddWithValue("@Nama", txtNama.Text);
            command.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
            command.Parameters.AddWithValue("@Telp", txtTelp.Text);
            command.Parameters.AddWithValue("@Hp", txtHp.Text);
            command.Parameters.AddWithValue("@Updated_at", time);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("" + table + " berhasil diUpdate!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }

        
        public void deleteData(string table,TextBox txtID)
        {
            command = new MySqlCommand("delete from " + table + " where ID=@ID", conn);
            command.Parameters.AddWithValue("@ID", Convert.ToInt16(txtID.Text));
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("" + table + " berhasil diHapus!");
            }
            catch (Exception popup)
            {
                MessageBox.Show(popup.Message);
            }
        }
        
    }
}
