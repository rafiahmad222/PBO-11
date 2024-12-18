namespace PBO_Projek.Views
{
    partial class FormDataKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataKasir));
            btnSave = new Button();
            txtUserKas = new TextBox();
            btnBack = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            txtNamaKas = new TextBox();
            label3 = new Label();
            txtPassKas = new TextBox();
            label4 = new Label();
            btnUpdate = new Button();
            lblEid = new Label();
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
            btnSave.Location = new Point(45, 478);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 54);
            btnSave.TabIndex = 36;
            btnSave.Text = "Tambah";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtUserKas
            // 
            txtUserKas.Location = new Point(138, 326);
            txtUserKas.Name = "txtUserKas";
            txtUserKas.Size = new Size(228, 27);
            txtUserKas.TabIndex = 35;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(13, 48);
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
            label2.Location = new Point(27, 327);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 33;
            label2.Text = "Username :";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 189);
            label1.Name = "label1";
            label1.Size = new Size(195, 34);
            label1.TabIndex = 31;
            label1.Text = "Tambah Kasir";
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
            // txtNamaKas
            // 
            txtNamaKas.Location = new Point(138, 275);
            txtNamaKas.Name = "txtNamaKas";
            txtNamaKas.Size = new Size(228, 27);
            txtNamaKas.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 276);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 37;
            label3.Text = "Nama Kasir :";
            // 
            // txtPassKas
            // 
            txtPassKas.Location = new Point(138, 381);
            txtPassKas.Name = "txtPassKas";
            txtPassKas.Size = new Size(228, 27);
            txtPassKas.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 382);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 39;
            label4.Text = "Password :";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 128);
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ImageAlign = ContentAlignment.BottomCenter;
            btnUpdate.Location = new Point(223, 478);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 54);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button1_Click;
            // 
            // lblEid
            // 
            lblEid.AutoSize = true;
            lblEid.Location = new Point(336, 52);
            lblEid.Name = "lblEid";
            lblEid.Size = new Size(30, 20);
            lblEid.TabIndex = 42;
            lblEid.Text = "Eid";
            lblEid.Click += label5_Click;
            // 
            // FormDataKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 570);
            Controls.Add(lblEid);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassKas);
            Controls.Add(label4);
            Controls.Add(txtNamaKas);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(txtUserKas);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDataKasir";
            Text = "FormDataKasir";
            Load += FormDataKasir_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtUserKas;
        private Button btnBack;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        public TextBox txtNamaKas;
        private Label label3;
        public TextBox txtPassKas;
        private Label label4;
        public Label lblEid;
        public Button btnSave;
        public Button btnUpdate;
    }
}