namespace PBO_Projek.Views.Teknisi
{
    partial class V_Transaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Transaksi));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dataGridViewAlat = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            dataGridViewProduk = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dataGridViewPesanan = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Hapus = new DataGridViewImageColumn();
            panel4 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox3 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            textBox4 = new TextBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlat).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduk).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesanan).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 64);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 28);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Nama Pembeli :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 66);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Kode Penjualan :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewAlat);
            panel3.Location = new Point(35, 144);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 368);
            panel3.TabIndex = 4;
            // 
            // dataGridViewAlat
            // 
            dataGridViewAlat.AllowUserToAddRows = false;
            dataGridViewAlat.AllowUserToDeleteRows = false;
            dataGridViewAlat.AllowUserToResizeColumns = false;
            dataGridViewAlat.AllowUserToResizeRows = false;
            dataGridViewAlat.BackgroundColor = Color.White;
            dataGridViewAlat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LimeGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAlat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAlat.ColumnHeadersHeight = 35;
            dataGridViewAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAlat.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, Column4 });
            dataGridViewAlat.Dock = DockStyle.Top;
            dataGridViewAlat.EnableHeadersVisualStyles = false;
            dataGridViewAlat.Location = new Point(0, 0);
            dataGridViewAlat.Margin = new Padding(3, 2, 3, 2);
            dataGridViewAlat.Name = "dataGridViewAlat";
            dataGridViewAlat.RowHeadersVisible = false;
            dataGridViewAlat.RowHeadersWidth = 51;
            dataGridViewAlat.Size = new Size(307, 368);
            dataGridViewAlat.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Nama Alat Pertanian";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Harga";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 62;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewProduk);
            panel1.Location = new Point(357, 144);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 368);
            panel1.TabIndex = 5;
            // 
            // dataGridViewProduk
            // 
            dataGridViewProduk.AllowUserToAddRows = false;
            dataGridViewProduk.AllowUserToDeleteRows = false;
            dataGridViewProduk.AllowUserToResizeColumns = false;
            dataGridViewProduk.AllowUserToResizeRows = false;
            dataGridViewProduk.BackgroundColor = Color.White;
            dataGridViewProduk.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LimeGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProduk.ColumnHeadersHeight = 35;
            dataGridViewProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewProduk.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, Column2 });
            dataGridViewProduk.Dock = DockStyle.Top;
            dataGridViewProduk.EnableHeadersVisualStyles = false;
            dataGridViewProduk.Location = new Point(0, 0);
            dataGridViewProduk.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProduk.Name = "dataGridViewProduk";
            dataGridViewProduk.RowHeadersVisible = false;
            dataGridViewProduk.RowHeadersWidth = 51;
            dataGridViewProduk.Size = new Size(307, 368);
            dataGridViewProduk.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Nama Produk";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column2
            // 
            Column2.HeaderText = "Harga";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewPesanan);
            panel2.Location = new Point(724, 144);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 368);
            panel2.TabIndex = 6;
            // 
            // dataGridViewPesanan
            // 
            dataGridViewPesanan.AllowUserToAddRows = false;
            dataGridViewPesanan.AllowUserToDeleteRows = false;
            dataGridViewPesanan.AllowUserToResizeColumns = false;
            dataGridViewPesanan.AllowUserToResizeRows = false;
            dataGridViewPesanan.BackgroundColor = Color.White;
            dataGridViewPesanan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LimeGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewPesanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewPesanan.ColumnHeadersHeight = 35;
            dataGridViewPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPesanan.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column1, dataGridViewTextBoxColumn2, Hapus });
            dataGridViewPesanan.Dock = DockStyle.Top;
            dataGridViewPesanan.EnableHeadersVisualStyles = false;
            dataGridViewPesanan.Location = new Point(0, 0);
            dataGridViewPesanan.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPesanan.Name = "dataGridViewPesanan";
            dataGridViewPesanan.RowHeadersVisible = false;
            dataGridViewPesanan.RowHeadersWidth = 51;
            dataGridViewPesanan.Size = new Size(289, 368);
            dataGridViewPesanan.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Pesanan";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Qty";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Harga";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 62;
            // 
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Hapus.HeaderText = "";
            Hapus.Image = (Image)resources.GetObject("Hapus.Image");
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Width = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 166, 0);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(724, 554);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 33);
            panel4.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(92, 9);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(88, 8);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(8, 8);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 0;
            label7.Text = "Total Harga:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 554);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(357, 554);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(308, 23);
            comboBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(357, 615);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 23);
            textBox3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 532);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 10;
            label3.Text = "Alat Pertanian Yang Disewa :\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 532);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 11;
            label4.Text = "Produk Yang Dibeli :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 598);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 12;
            label5.Text = "Jumlah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 105);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 13;
            label6.Text = "Kasir   :";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(149, 103);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(180, 23);
            comboBox3.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(95, 667);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(167, 26);
            button1.TabIndex = 15;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(410, 667);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(167, 26);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(805, 667);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(114, 26);
            button3.TabIndex = 17;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(724, 591);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 19;
            label8.Text = "Bayar";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(724, 608);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(289, 23);
            textBox4.TabIndex = 18;
            // 
            // V_Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(panel4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_Transaksi";
            Size = new Size(1037, 728);
            Load += V_Transaksi_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlat).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduk).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesanan).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private DataGridView dataGridViewAlat;
        private Panel panel1;
        private DataGridView dataGridViewProduk;
        private Panel panel2;
        private DataGridView dataGridViewPesanan;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel4;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn Hapus;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column2;
    }
}
