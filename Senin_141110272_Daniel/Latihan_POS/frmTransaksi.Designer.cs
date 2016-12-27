namespace Latihan_POS
{
    partial class frmTransaksi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.browseC = new System.Windows.Forms.Button();
            this.browseB = new System.Windows.Forms.Button();
            this.beli = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.Button();
            this.totalHarga = new System.Windows.Forms.TextBox();
            this.jlhBarang = new System.Windows.Forms.TextBox();
            this.srcCust = new System.Windows.Forms.TextBox();
            this.srcBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.harga = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.harga);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtCust);
            this.tabPage1.Controls.Add(this.txtBarang);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.browseC);
            this.tabPage1.Controls.Add(this.browseB);
            this.tabPage1.Controls.Add(this.beli);
            this.tabPage1.Controls.Add(this.cart);
            this.tabPage1.Controls.Add(this.totalHarga);
            this.tabPage1.Controls.Add(this.jlhBarang);
            this.tabPage1.Controls.Add(this.srcCust);
            this.tabPage1.Controls.Add(this.srcBarang);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1029, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(136, 120);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(100, 20);
            this.txtCust.TabIndex = 15;
            // 
            // txtBarang
            // 
            this.txtBarang.Location = new System.Drawing.Point(136, 52);
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.Size = new System.Drawing.Size(100, 20);
            this.txtBarang.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nama Barang";
            // 
            // browseC
            // 
            this.browseC.Location = new System.Drawing.Point(242, 91);
            this.browseC.Name = "browseC";
            this.browseC.Size = new System.Drawing.Size(34, 23);
            this.browseC.TabIndex = 12;
            this.browseC.Text = "...";
            this.browseC.UseVisualStyleBackColor = true;
            this.browseC.Click += new System.EventHandler(this.browseC_Click);
            // 
            // browseB
            // 
            this.browseB.Location = new System.Drawing.Point(242, 16);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(34, 23);
            this.browseB.TabIndex = 11;
            this.browseB.Text = "...";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // beli
            // 
            this.beli.Location = new System.Drawing.Point(920, 185);
            this.beli.Name = "beli";
            this.beli.Size = new System.Drawing.Size(75, 23);
            this.beli.TabIndex = 10;
            this.beli.Text = "Beli";
            this.beli.UseVisualStyleBackColor = true;
            this.beli.Click += new System.EventHandler(this.beli_Click);
            // 
            // cart
            // 
            this.cart.Location = new System.Drawing.Point(136, 225);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(75, 23);
            this.cart.TabIndex = 9;
            this.cart.Text = "Add Cart";
            this.cart.UseVisualStyleBackColor = true;
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // totalHarga
            // 
            this.totalHarga.Location = new System.Drawing.Point(136, 181);
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Size = new System.Drawing.Size(100, 20);
            this.totalHarga.TabIndex = 7;
            // 
            // jlhBarang
            // 
            this.jlhBarang.Location = new System.Drawing.Point(136, 148);
            this.jlhBarang.Name = "jlhBarang";
            this.jlhBarang.Size = new System.Drawing.Size(100, 20);
            this.jlhBarang.TabIndex = 6;
            this.jlhBarang.TextChanged += new System.EventHandler(this.jlhBarang_TextChanged);
            // 
            // srcCust
            // 
            this.srcCust.Location = new System.Drawing.Point(136, 94);
            this.srcCust.Name = "srcCust";
            this.srcCust.Size = new System.Drawing.Size(100, 20);
            this.srcCust.TabIndex = 5;
            // 
            // srcBarang
            // 
            this.srcBarang.Location = new System.Drawing.Point(136, 18);
            this.srcBarang.Name = "srcBarang";
            this.srcBarang.Size = new System.Drawing.Size(100, 20);
            this.srcBarang.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cari Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Barang";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1029, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(402, 248);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(35, 13);
            this.harga.TabIndex = 17;
            this.harga.Text = "label6";
            // 
            // frmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 529);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTransaksi";
            this.Text = "frmTransaksi";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox totalHarga;
        private System.Windows.Forms.TextBox jlhBarang;
        private System.Windows.Forms.TextBox srcCust;
        private System.Windows.Forms.TextBox srcBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button browseC;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.Button beli;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarang;
        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label harga;
    }
}