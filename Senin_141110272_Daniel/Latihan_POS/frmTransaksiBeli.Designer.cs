namespace Latihan_POS
{
    partial class frmTransaksiBeli
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.srcBarang = new System.Windows.Forms.TextBox();
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.srcSupp = new System.Windows.Forms.TextBox();
            this.txtSupp = new System.Windows.Forms.TextBox();
            this.jlhBarang = new System.Windows.Forms.TextBox();
            this.totalHarga = new System.Windows.Forms.TextBox();
            this.browseB = new System.Windows.Forms.Button();
            this.browseS = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Barang (ID)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cari Supplier (ID)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jumlah Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga /Pcs";
            // 
            // srcBarang
            // 
            this.srcBarang.Location = new System.Drawing.Point(112, 117);
            this.srcBarang.Multiline = true;
            this.srcBarang.Name = "srcBarang";
            this.srcBarang.Size = new System.Drawing.Size(190, 31);
            this.srcBarang.TabIndex = 6;
            // 
            // txtBarang
            // 
            this.txtBarang.Location = new System.Drawing.Point(112, 154);
            this.txtBarang.Multiline = true;
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.Size = new System.Drawing.Size(190, 31);
            this.txtBarang.TabIndex = 7;
            // 
            // srcSupp
            // 
            this.srcSupp.Location = new System.Drawing.Point(112, 191);
            this.srcSupp.Multiline = true;
            this.srcSupp.Name = "srcSupp";
            this.srcSupp.Size = new System.Drawing.Size(190, 31);
            this.srcSupp.TabIndex = 8;
            // 
            // txtSupp
            // 
            this.txtSupp.Location = new System.Drawing.Point(112, 228);
            this.txtSupp.Multiline = true;
            this.txtSupp.Name = "txtSupp";
            this.txtSupp.Size = new System.Drawing.Size(190, 31);
            this.txtSupp.TabIndex = 9;
            // 
            // jlhBarang
            // 
            this.jlhBarang.Location = new System.Drawing.Point(112, 265);
            this.jlhBarang.Multiline = true;
            this.jlhBarang.Name = "jlhBarang";
            this.jlhBarang.Size = new System.Drawing.Size(190, 29);
            this.jlhBarang.TabIndex = 10;
            // 
            // totalHarga
            // 
            this.totalHarga.Location = new System.Drawing.Point(112, 300);
            this.totalHarga.Multiline = true;
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Size = new System.Drawing.Size(190, 31);
            this.totalHarga.TabIndex = 11;
            // 
            // browseB
            // 
            this.browseB.Location = new System.Drawing.Point(302, 117);
            this.browseB.Name = "browseB";
            this.browseB.Size = new System.Drawing.Size(42, 31);
            this.browseB.TabIndex = 12;
            this.browseB.Text = "Cari";
            this.browseB.UseVisualStyleBackColor = true;
            this.browseB.Click += new System.EventHandler(this.browseB_Click);
            // 
            // browseS
            // 
            this.browseS.Location = new System.Drawing.Point(302, 191);
            this.browseS.Name = "browseS";
            this.browseS.Size = new System.Drawing.Size(42, 31);
            this.browseS.TabIndex = 13;
            this.browseS.Text = "Cari";
            this.browseS.UseVisualStyleBackColor = true;
            this.browseS.Click += new System.EventHandler(this.browseS_Click);
            // 
            // cart
            // 
            this.cart.Location = new System.Drawing.Point(227, 363);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(75, 23);
            this.cart.TabIndex = 14;
            this.cart.Text = "Beli";
            this.cart.UseVisualStyleBackColor = true;
            this.cart.Click += new System.EventHandler(this.cart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 295);
            this.dataGridView1.TabIndex = 15;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(84, 363);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 16;
            this.clear.Text = "Reset";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 61);
            this.label7.TabIndex = 17;
            this.label7.Text = "FORM PEMBELIAN";
            // 
            // frmTransaksiBeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 453);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.browseS);
            this.Controls.Add(this.browseB);
            this.Controls.Add(this.totalHarga);
            this.Controls.Add(this.jlhBarang);
            this.Controls.Add(this.txtSupp);
            this.Controls.Add(this.srcSupp);
            this.Controls.Add(this.txtBarang);
            this.Controls.Add(this.srcBarang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransaksiBeli";
            this.Text = "frmTransaksiBeli";
            this.Load += new System.EventHandler(this.frmTransaksiBeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button browseB;
        private System.Windows.Forms.Button browseS;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox srcBarang;
        public System.Windows.Forms.TextBox txtBarang;
        public System.Windows.Forms.TextBox srcSupp;
        public System.Windows.Forms.TextBox txtSupp;
        public System.Windows.Forms.TextBox jlhBarang;
        public System.Windows.Forms.TextBox totalHarga;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label7;
    }
}