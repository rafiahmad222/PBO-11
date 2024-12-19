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
            btnBack = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblEid = new Label();
            btnUpdate = new Button();
            txtPassKas = new TextBox();
            label4 = new Label();
            txtNamaKas = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            txtUserKas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(11, 36);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(26, 22);
            btnBack.TabIndex = 34;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 29);
            panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 33);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // lblEid
            // 
            lblEid.AutoSize = true;
            lblEid.Location = new Point(294, 35);
            lblEid.Name = "lblEid";
            lblEid.Size = new Size(23, 15);
            lblEid.TabIndex = 53;
            lblEid.Text = "Eid";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 128);
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ImageAlign = ContentAlignment.BottomCenter;
            btnUpdate.Location = new Point(194, 415);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 40);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtPassKas
            // 
            txtPassKas.Location = new Point(120, 343);
            txtPassKas.Margin = new Padding(3, 2, 3, 2);
            txtPassKas.Name = "txtPassKas";
            txtPassKas.Size = new Size(200, 23);
            txtPassKas.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 343);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 50;
            label4.Text = "Password :";
            // 
            // txtNamaKas
            // 
            txtNamaKas.Location = new Point(120, 263);
            txtNamaKas.Margin = new Padding(3, 2, 3, 2);
            txtNamaKas.Name = "txtNamaKas";
            txtNamaKas.Size = new Size(200, 23);
            txtNamaKas.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 264);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 48;
            label3.Text = "Nama Kasir :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 255, 128);
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ImageAlign = ContentAlignment.BottomCenter;
            btnSave.Location = new Point(38, 415);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 40);
            btnSave.TabIndex = 47;
            btnSave.Text = "Tambah";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // txtUserKas
            // 
            txtUserKas.Location = new Point(120, 301);
            txtUserKas.Margin = new Padding(3, 2, 3, 2);
            txtUserKas.Name = "txtUserKas";
            txtUserKas.Size = new Size(200, 23);
            txtUserKas.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 302);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 45;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 204);
            label1.Name = "label1";
            label1.Size = new Size(159, 26);
            label1.TabIndex = 44;
            label1.Text = "Tambah Kasir";
            // 
            // FormDataKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 483);
            Controls.Add(lblEid);
            Controls.Add(btnUpdate);
            Controls.Add(txtPassKas);
            Controls.Add(label4);
            Controls.Add(txtNamaKas);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(txtUserKas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDataKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDataKasir";
            Load += FormDataKasir_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private Panel panel1;
        private PictureBox pictureBox1;
        public Label lblEid;
        public Button btnUpdate;
        public TextBox txtPassKas;
        private Label label4;
        public TextBox txtNamaKas;
        private Label label3;
        public Button btnSave;
        public TextBox txtUserKas;
        private Label label2;
        private Label label1;
    }
}