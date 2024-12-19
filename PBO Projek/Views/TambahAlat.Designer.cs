namespace PBO_Projek.Views
{
    partial class TambahAlat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahAlat));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAlat = new TextBox();
            txtHargaAlat = new TextBox();
            button2 = new Button();
            button3 = new Button();
            btnBack = new Button();
            lblid = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 22);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 1;
            label1.Text = "Tambah Alat Pertanian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 69);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama Alat Pertanian :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 107);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 3;
            label3.Text = "Harga                        :";
            // 
            // txtAlat
            // 
            txtAlat.Location = new Point(148, 69);
            txtAlat.Margin = new Padding(3, 2, 3, 2);
            txtAlat.Name = "txtAlat";
            txtAlat.Size = new Size(462, 23);
            txtAlat.TabIndex = 4;
            // 
            // txtHargaAlat
            // 
            txtHargaAlat.Location = new Point(148, 107);
            txtHargaAlat.Margin = new Padding(3, 2, 3, 2);
            txtHargaAlat.Name = "txtHargaAlat";
            txtHargaAlat.Size = new Size(462, 23);
            txtHargaAlat.TabIndex = 5;
            txtHargaAlat.KeyPress += txtHargaAlat_KeyPress;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(396, 154);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 7;
            button2.Text = "Tambah";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(509, 154);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(590, 23);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(26, 22);
            btnBack.TabIndex = 25;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(13, 154);
            lblid.Name = "lblid";
            lblid.Size = new Size(23, 15);
            lblid.TabIndex = 26;
            lblid.Text = "Eid";
            // 
            // TambahAlat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 217);
            Controls.Add(lblid);
            Controls.Add(btnBack);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtHargaAlat);
            Controls.Add(txtAlat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TambahAlat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TambahLayanan";
            Load += TambahAlat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button btnBack;
        public Label lblid;
        public TextBox txtAlat;
        public TextBox txtHargaAlat;
    }
}