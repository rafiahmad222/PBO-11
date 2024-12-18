namespace PBO_Projek.Views
{
    partial class FormSukuCadang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSukuCadang));
            btnBack = new Button();
            button3 = new Button();
            button2 = new Button();
            txtHarSuk = new TextBox();
            txtSuku = new TextBox();
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
            btnBack.Location = new Point(587, 37);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 34;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(487, 236);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
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
            button2.Location = new Point(354, 236);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 32;
            button2.Text = "Tambah";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtHarSuk
            // 
            txtHarSuk.Location = new Point(157, 138);
            txtHarSuk.Name = "txtHarSuk";
            txtHarSuk.Size = new Size(182, 27);
            txtHarSuk.TabIndex = 31;
            txtHarSuk.TextChanged += txtHarSuk_TextChanged;
            txtHarSuk.KeyPress += txtHarSuk_KeyPress;
            // 
            // txtSuku
            // 
            txtSuku.Location = new Point(157, 85);
            txtSuku.Name = "txtSuku";
            txtSuku.Size = new Size(424, 27);
            txtSuku.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 138);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 29;
            label3.Text = "Harga Rp. :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 87);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 28;
            label2.Text = "Nama Produk :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 39);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 27;
            label1.Text = "Tambah Produk";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 29);
            panel1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 142);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 35;
            label4.Text = "Stok :";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(467, 138);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(114, 27);
            txtStok.TabIndex = 36;
            txtStok.KeyPress += txtStok_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(157, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 37;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 198);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 38;
            label5.Text = "Kategori :";
            label5.Click += label5_Click;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new Point(403, 39);
            labelid.Name = "labelid";
            labelid.Size = new Size(22, 20);
            labelid.TabIndex = 39;
            labelid.Text = "Id";
            // 
            // FormSukuCadang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 285);
            Controls.Add(labelid);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(txtStok);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtHarSuk);
            Controls.Add(txtSuku);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSukuCadang";
            Text = "FormSukuCadang";
            Load += FormSukuCadang_Load;
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
        public TextBox txtHarSuk;
        public TextBox txtSuku;
        public TextBox txtStok;
        public ComboBox comboBox1;
        public Label labelid;
    }
}