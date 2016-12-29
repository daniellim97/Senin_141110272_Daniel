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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.browseC = new System.Windows.Forms.Button();
            this.browseB = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.Button();
            this.totalHarga = new System.Windows.Forms.TextBox();
            this.jlhBarang = new System.Windows.Forms.TextBox();
            this.srcCust = new System.Windows.Forms.TextBox();
            this.srcBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 277);
            this.dataGridView1.TabIndex = 16;
            // 
            // txtCust
            // 
            this.txtCust.Location = new System.Drawing.Point(116, 230);
            this.txtCust.Multiline = true;
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(191, 30);
            this.txtCust.TabIndex = 15;
            // 
            // txtBarang
            // 
            this.txtBarang.Location = new System.Drawing.Point(116, 159);
            this.txtBarang.Multiline = true;
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.Size = new System.Drawing.Size(191, 29);
            this.txtBarang.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nama Barang";
            // 
            // browseC
            // 
            this.browseC.Location = new System.Drawing.Point(307, 193);
            this.browseC.Name = "browseC";
            this.browseC.Size = new System.Drawing.Size(40, 30);
            this.browseC.TabIndex = 12;
            this.browseC.Text = "Cari";
            this.browseC.UseVisualStyleBackColor = true;
            this.browseC.Click += new System.EventHandler(this.browseC_Click);
            // 
            // browseB
            // 
            this.browseB.Location = new System.Drawing.Point(307, 123);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(40, 29);
            this.browseB.TabIndex = 11;
            this.browseB.Text = "Cari";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // cart
            // 
            this.cart.Location = new System.Drawing.Point(232, 360);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(75, 23);
            this.cart.TabIndex = 9;
            this.cart.Text = "Beli";
            this.cart.UseVisualStyleBackColor = true;
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // totalHarga
            // 
            this.totalHarga.Location = new System.Drawing.Point(116, 302);
            this.totalHarga.Multiline = true;
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Size = new System.Drawing.Size(191, 30);
            this.totalHarga.TabIndex = 7;
            // 
            // jlhBarang
            // 
            this.jlhBarang.Location = new System.Drawing.Point(116, 266);
            this.jlhBarang.Multiline = true;
            this.jlhBarang.Name = "jlhBarang";
            this.jlhBarang.Size = new System.Drawing.Size(191, 30);
            this.jlhBarang.TabIndex = 6;
            this.jlhBarang.TextChanged += new System.EventHandler(this.jlhBarang_TextChanged);
            // 
            // srcCust
            // 
            this.srcCust.Location = new System.Drawing.Point(116, 194);
            this.srcCust.Multiline = true;
            this.srcCust.Name = "srcCust";
            this.srcCust.Size = new System.Drawing.Size(191, 30);
            this.srcCust.TabIndex = 5;
            // 
            // srcBarang
            // 
            this.srcBarang.Location = new System.Drawing.Point(116, 123);
            this.srcBarang.Multiline = true;
            this.srcBarang.Name = "srcBarang";
            this.srcBarang.Size = new System.Drawing.Size(191, 30);
            this.srcBarang.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga /Pcs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cari Customer (ID)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Barang (ID)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nama Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 61);
            this.label7.TabIndex = 19;
            this.label7.Text = "FORM PENJUALAN";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(98, 362);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 20;
            this.clear.Text = "Reset";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // frmTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 457);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.txtCust);
            this.Controls.Add(this.totalHarga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jlhBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.browseC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBarang);
            this.Controls.Add(this.srcBarang);
            this.Controls.Add(this.browseB);
            this.Controls.Add(this.srcCust);
            this.Controls.Add(this.label2);
            this.Name = "frmTransaksi";
            this.Text = "frmTransaksi";
            this.Load += new System.EventHandler(this.frmTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseC;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox totalHarga;
        public System.Windows.Forms.TextBox jlhBarang;
        public System.Windows.Forms.TextBox srcCust;
        public System.Windows.Forms.TextBox srcBarang;
        public System.Windows.Forms.TextBox txtBarang;
        public System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear;
    }
}