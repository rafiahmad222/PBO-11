namespace PBO_Projek.View
{
    partial class V_TambahProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_TambahProduk));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            label1 = new Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            Deskripsi = new TextBox();
            label4 = new Label();
            txtHarga = new TextBox();
            label5 = new Label();
            txtNamaProduk = new TextBox();
            label6 = new Label();
            txtJumlahStok = new TextBox();
            label7 = new Label();
            txtKategori = new TextBox();
            dtpTanggalKedaluwarsa = new DateTimePicker();
            label8 = new Label();
            Tambah = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 113, 17);
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(guna2PictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 76);
            panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.BackgroundImage = (Image)resources.GetObject("guna2PictureBox1.BackgroundImage");
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-20, -50);
            guna2PictureBox1.Margin = new Padding(2);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(196, 175);
            guna2PictureBox1.TabIndex = 1;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.UseTransparentBackground = true;
            guna2PictureBox1.Click += guna2PictureBox1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 2;
            label1.Text = "Tambah Produk";
            label1.Click += label1_Click;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Chartreuse;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(424, 20);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new Size(56, 36);
            guna2ControlBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(180, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 222);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Deskripsi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 17);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Foto Produk:";
            label2.Click += label2_Click;
            // 
            // Deskripsi
            // 
            Deskripsi.Location = new Point(19, 245);
            Deskripsi.Name = "Deskripsi";
            Deskripsi.RightToLeft = RightToLeft.Yes;
            Deskripsi.Size = new Size(163, 27);
            Deskripsi.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 288);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 4;
            label4.Text = "Masukkan Harga:";
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(19, 311);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(163, 27);
            txtHarga.TabIndex = 5;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 156);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 6;
            label5.Text = "Nama Produk:";
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.Location = new Point(19, 179);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.RightToLeft = RightToLeft.Yes;
            txtNamaProduk.Size = new Size(163, 27);
            txtNamaProduk.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 156);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 8;
            label6.Text = "Stok Produk:";
            label6.Click += this.label6_Click;
            // 
            // txtJumlahStok
            // 
            txtJumlahStok.Location = new Point(212, 179);
            txtJumlahStok.Name = "txtJumlahStok";
            txtJumlahStok.RightToLeft = RightToLeft.Yes;
            txtJumlahStok.Size = new Size(250, 27);
            txtJumlahStok.TabIndex = 9;
            txtJumlahStok.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 222);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 11;
            label7.Text = "Kategori:";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(212, 245);
            txtKategori.Name = "txtKategori";
            txtKategori.RightToLeft = RightToLeft.Yes;
            txtKategori.Size = new Size(250, 27);
            txtKategori.TabIndex = 12;
            // 
            // dtpTanggalKedaluwarsa
            // 
            dtpTanggalKedaluwarsa.Location = new Point(212, 311);
            dtpTanggalKedaluwarsa.Name = "dtpTanggalKedaluwarsa";
            dtpTanggalKedaluwarsa.Size = new Size(250, 27);
            dtpTanggalKedaluwarsa.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 288);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 14;
            label8.Text = "Expired Date:";
            label8.Click += label8_Click;
            // 
            // Tambah
            // 
            Tambah.BackColor = Color.FromArgb(195, 233, 86);
            Tambah.Location = new Point(148, 377);
            Tambah.Name = "Tambah";
            Tambah.Size = new Size(171, 46);
            Tambah.TabIndex = 15;
            Tambah.Text = "Tambah";
            Tambah.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(Tambah);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dtpTanggalKedaluwarsa);
            panel2.Controls.Add(txtKategori);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtJumlahStok);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtNamaProduk);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtHarga);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Deskripsi);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(492, 467);
            panel2.TabIndex = 16;
            // 
            // V_TambahProduk
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(491, 536);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_TambahProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_TambahProduk";
            Load += V_TambahProduk_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox Deskripsi;
        private Label label4;
        private TextBox txtHarga;
        private Label label5;
        private TextBox txtNamaProduk;
        private Label label6;
        private TextBox txtJumlahStok;
        private Label label7;
        private TextBox txtKategori;
        private DateTimePicker dtpTanggalKedaluwarsa;
        private Label label8;
        private Button Tambah;
        private Panel panel2;
    }
}