namespace PBO_Projek.Views.Homepage
{
    partial class V_RiwayatTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatTransaksi));
            panel3 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            dgvLay = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Detail = new DataGridViewImageColumn();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLay).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dgvLay);
            panel3.Location = new Point(116, 180);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 368);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 330);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(803, 38);
            panel4.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 10);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 11);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // dgvLay
            // 
            dgvLay.AllowUserToAddRows = false;
            dgvLay.AllowUserToDeleteRows = false;
            dgvLay.AllowUserToResizeColumns = false;
            dgvLay.AllowUserToResizeRows = false;
            dgvLay.BackgroundColor = Color.White;
            dgvLay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LimeGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLay.ColumnHeadersHeight = 35;
            dgvLay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLay.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column8, Column4, Column5, Detail });
            dgvLay.Dock = DockStyle.Top;
            dgvLay.EnableHeadersVisualStyles = false;
            dgvLay.Location = new Point(0, 0);
            dgvLay.Margin = new Padding(3, 2, 3, 2);
            dgvLay.Name = "dgvLay";
            dgvLay.RowHeadersVisible = false;
            dgvLay.RowHeadersWidth = 51;
            dgvLay.Size = new Size(803, 492);
            dgvLay.TabIndex = 0;
            dgvLay.CellContentClick += dgvLay_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 46;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id Transaksi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 83;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Nama Pembeli";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Kode Penjualan";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 103;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Nama Kasir";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 83;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Tanggal Transaksi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 111;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Total Harga";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 83;
            // 
            // Detail
            // 
            Detail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Detail.HeaderText = "";
            Detail.Image = (Image)resources.GetObject("Detail.Image");
            Detail.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Detail.MinimumWidth = 6;
            Detail.Name = "Detail";
            Detail.Width = 6;
            // 
            // V_RiwayatTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_RiwayatTransaksi";
            Size = new Size(1037, 728);
            Load += V_RiwayatTransaksi_Load;
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private Label label2;
        public DataGridView dgvLay;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Detail;
    }
}
