namespace PBO_Projek.Views
{
    partial class FormTambahProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahProduk));
            btnBack = new Button();
            button3 = new Button();
            button2 = new Button();
            txtHargaProduk = new TextBox();
            txtNamaProduk = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            txtStok = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            labelid = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(514, 28);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(26, 22);
            btnBack.TabIndex = 34;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(437, 196);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 33;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(321, 196);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 32;
            button2.Text = "Tambah";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtHargaProduk
            // 
            txtHargaProduk.Location = new Point(137, 104);
            txtHargaProduk.Margin = new Padding(3, 2, 3, 2);
            txtHargaProduk.Name = "txtHargaProduk";
            txtHargaProduk.Size = new Size(160, 23);
            txtHargaProduk.TabIndex = 31;
            txtHargaProduk.TextChanged += txtHarSuk_TextChanged;
            txtHargaProduk.KeyPress += txtHarSuk_KeyPress;
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.Location = new Point(137, 64);
            txtNamaProduk.Margin = new Padding(3, 2, 3, 2);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(403, 23);
            txtNamaProduk.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 104);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 29;
            label3.Text = "Harga Rp. :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 65);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 28;
            label2.Text = "Nama Produk :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(4, 29);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 27;
            label1.Text = "Tambah Produk";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 22);
            panel1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 106);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 35;
            label4.Text = "Stok :";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(409, 104);
            txtStok.Margin = new Padding(3, 2, 3, 2);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(131, 23);
            txtStok.TabIndex = 36;
            txtStok.KeyPress += txtStok_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 145);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 37;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 148);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 38;
            label5.Text = "Kategori :";
            label5.Click += label5_Click;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new Point(353, 29);
            labelid.Name = "labelid";
            labelid.Size = new Size(17, 15);
            labelid.TabIndex = 39;
            labelid.Text = "Id";
            // 
            // FormTambahProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 244);
            Controls.Add(labelid);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(txtStok);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtHargaProduk);
            Controls.Add(txtNamaProduk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTambahProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSukuCadang";
            Load += FormProduk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button button3;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        public TextBox txtHargaProduk;
        public TextBox txtNamaProduk;
        public TextBox txtStok;
        public ComboBox comboBox1;
        public Label labelid;
    }
}