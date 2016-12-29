namespace Latihan_POS
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrasiToolStripMenuItem,
            this.editToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.pembelianToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrasiToolStripMenuItem
            // 
            this.registrasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahBarangToolStripMenuItem,
            this.tambahCustomerToolStripMenuItem,
            this.tambahSupplierToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.registrasiToolStripMenuItem.Name = "registrasiToolStripMenuItem";
            this.registrasiToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.registrasiToolStripMenuItem.Text = "Registrasi";
            // 
            // tambahBarangToolStripMenuItem
            // 
            this.tambahBarangToolStripMenuItem.Name = "tambahBarangToolStripMenuItem";
            this.tambahBarangToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tambahBarangToolStripMenuItem.Text = "Tambah Barang";
            this.tambahBarangToolStripMenuItem.Click += new System.EventHandler(this.tambahBarangToolStripMenuItem_Click);
            // 
            // tambahCustomerToolStripMenuItem
            // 
            this.tambahCustomerToolStripMenuItem.Name = "tambahCustomerToolStripMenuItem";
            this.tambahCustomerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tambahCustomerToolStripMenuItem.Text = "Tambah Customer";
            this.tambahCustomerToolStripMenuItem.Click += new System.EventHandler(this.tambahCustomerToolStripMenuItem_Click);
            // 
            // tambahSupplierToolStripMenuItem
            // 
            this.tambahSupplierToolStripMenuItem.Name = "tambahSupplierToolStripMenuItem";
            this.tambahSupplierToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tambahSupplierToolStripMenuItem.Text = "Tambah Supplier";
            this.tambahSupplierToolStripMenuItem.Click += new System.EventHandler(this.tambahSupplierToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBarangToolStripMenuItem,
            this.editCustomerToolStripMenuItem,
            this.editSupplierToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editBarangToolStripMenuItem
            // 
            this.editBarangToolStripMenuItem.Name = "editBarangToolStripMenuItem";
            this.editBarangToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editBarangToolStripMenuItem.Text = "Edit Barang";
            this.editBarangToolStripMenuItem.Click += new System.EventHandler(this.editBarangToolStripMenuItem_Click);
            // 
            // editCustomerToolStripMenuItem
            // 
            this.editCustomerToolStripMenuItem.Name = "editCustomerToolStripMenuItem";
            this.editCustomerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editCustomerToolStripMenuItem.Text = "Edit Customer";
            this.editCustomerToolStripMenuItem.Click += new System.EventHandler(this.editCustomerToolStripMenuItem_Click);
            // 
            // editSupplierToolStripMenuItem
            // 
            this.editSupplierToolStripMenuItem.Name = "editSupplierToolStripMenuItem";
            this.editSupplierToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editSupplierToolStripMenuItem.Text = "Edit Supplier";
            this.editSupplierToolStripMenuItem.Click += new System.EventHandler(this.editSupplierToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.transaksiToolStripMenuItem.Text = "Penjualan";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // pembelianToolStripMenuItem
            // 
            this.pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
            this.pembelianToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.pembelianToolStripMenuItem.Text = "Pembelian";
            this.pembelianToolStripMenuItem.Click += new System.EventHandler(this.pembelianToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 505);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelianToolStripMenuItem;
    }
}

