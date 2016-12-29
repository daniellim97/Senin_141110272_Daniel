namespace Latihan_POS
{
    partial class editBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtJlh = new System.Windows.Forms.MaskedTextBox();
            this.txtHpp = new System.Windows.Forms.TextBox();
            this.txtJual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(117, 14);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(243, 29);
            this.txtID.TabIndex = 1;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(376, 18);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(117, 49);
            this.txtKode.Multiline = true;
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(243, 28);
            this.txtKode.TabIndex = 3;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(117, 83);
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(243, 29);
            this.txtNama.TabIndex = 4;
            // 
            // txtJlh
            // 
            this.txtJlh.Location = new System.Drawing.Point(117, 122);
            this.txtJlh.Mask = "0000000000";
            this.txtJlh.Name = "txtJlh";
            this.txtJlh.Size = new System.Drawing.Size(243, 20);
            this.txtJlh.TabIndex = 5;
            // 
            // txtHpp
            // 
            this.txtHpp.Location = new System.Drawing.Point(117, 148);
            this.txtHpp.Multiline = true;
            this.txtHpp.Name = "txtHpp";
            this.txtHpp.Size = new System.Drawing.Size(243, 28);
            this.txtHpp.TabIndex = 6;
            // 
            // txtJual
            // 
            this.txtJual.Location = new System.Drawing.Point(117, 182);
            this.txtJual.Multiline = true;
            this.txtJual.Name = "txtJual";
            this.txtJual.Size = new System.Drawing.Size(243, 28);
            this.txtJual.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jumlah Awal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Harga HPP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Harga Jual";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(285, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(57, 231);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 400);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.btnCari);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtKode);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtJual);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtNama);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtHpp);
            this.tabPage1.Controls.Add(this.txtJlh);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSrc);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(318, 19);
            this.txtSrc.Multiline = true;
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(244, 25);
            this.txtSrc.TabIndex = 2;
            this.txtSrc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cari Berdasarkan Kode";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Form Edit Barang";
            // 
            // editBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 446);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tabControl1);
            this.Name = "editBarang";
            this.Text = "Form Edit Barang";
            this.Load += new System.EventHandler(this.editBarang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.MaskedTextBox txtJlh;
        private System.Windows.Forms.TextBox txtHpp;
        private System.Windows.Forms.TextBox txtJual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}