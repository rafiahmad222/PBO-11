namespace PBO_Projek.Views.Homepage
{
    partial class V_Produk
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Produk));
            dgvSukuCadang = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSukuCadang).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSukuCadang
            // 
            dgvSukuCadang.AllowUserToAddRows = false;
            dgvSukuCadang.AllowUserToDeleteRows = false;
            dgvSukuCadang.AllowUserToResizeColumns = false;
            dgvSukuCadang.AllowUserToResizeRows = false;
            dgvSukuCadang.BackgroundColor = Color.White;
            dgvSukuCadang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LimeGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSukuCadang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSukuCadang.ColumnHeadersHeight = 35;
            dgvSukuCadang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSukuCadang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column4, Column5, Edit });
            dgvSukuCadang.Dock = DockStyle.Top;
            dgvSukuCadang.EnableHeadersVisualStyles = false;
            dgvSukuCadang.Location = new Point(0, 0);
            dgvSukuCadang.Name = "dgvSukuCadang";
            dgvSukuCadang.RowHeadersVisible = false;
            dgvSukuCadang.RowHeadersWidth = 51;
            dgvSukuCadang.Size = new Size(708, 635);
            dgvSukuCadang.TabIndex = 1;
            dgvSukuCadang.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dgvSukuCadang);
            panel3.Location = new Point(244, 210);
            panel3.Name = "panel3";
            panel3.Size = new Size(708, 491);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(708, 50);
            panel4.TabIndex = 2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(576, 11);
            button1.Name = "button1";
            button1.Size = new Size(122, 30);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(442, 11);
            button2.Name = "button2";
            button2.Size = new Size(122, 30);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 15);
            label2.Name = "label2";
            label2.Size = new Size(72, 22);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 56;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Nama Produk";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.DataPropertyName = "Nama_Kategori";
            Column6.HeaderText = "Kategori";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 93;
            // 
            // Column4
            // 
            Column4.HeaderText = "Stok";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Harga";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // V_SukuCadang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel3);
            Name = "V_SukuCadang";
            Size = new Size(1185, 970);
            Load += V_SukuCadang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSukuCadang).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSukuCadang;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        public Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Edit;
    }
}
