namespace PBO_Projek.Views
{
    partial class FormTambahKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahKategori));
            btnSave = new Button();
            txtNamakategori = new TextBox();
            btnBack = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.BottomCenter;
            btnSave.Location = new Point(128, 456);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 54);
            btnSave.TabIndex = 36;
            btnSave.Text = "Tambah";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtNamakategori
            // 
            txtNamakategori.Location = new Point(143, 332);
            txtNamakategori.Name = "txtNamakategori";
            txtNamakategori.Size = new Size(196, 27);
            txtNamakategori.TabIndex = 35;
            txtNamakategori.TextChanged += txtNamaTek_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(13, 50);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(30, 30);
            btnBack.TabIndex = 34;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 336);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 33;
            label2.Text = "Nama Kategori :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-64, -153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 39);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 201);
            label1.Name = "label1";
            label1.Size = new Size(245, 34);
            label1.TabIndex = 37;
            label1.Text = "Tambah Kategori";
            // 
            // FormTambahKategori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 570);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtNamakategori);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTambahKategori";
            Text = "FormTambahKategori";
            Load += FormTambahKategori_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtNamakategori;
        private Button btnBack;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
    }
}