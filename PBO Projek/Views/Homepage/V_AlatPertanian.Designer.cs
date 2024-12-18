namespace PBO_Projek.Views.Homepage
{
    partial class V_AlatPertanian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AlatPertanian));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel3 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            dgvLay = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLay).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dgvLay);
            panel3.Location = new Point(126, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 491);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(918, 50);
            panel4.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(762, 11);
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
            dgvLay.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Edit });
            dgvLay.Dock = DockStyle.Top;
            dgvLay.EnableHeadersVisualStyles = false;
            dgvLay.Location = new Point(0, 0);
            dgvLay.Name = "dgvLay";
            dgvLay.RowHeadersVisible = false;
            dgvLay.RowHeadersWidth = 51;
            dgvLay.Size = new Size(918, 576);
            dgvLay.TabIndex = 0;
            dgvLay.CellContentClick += dgvLay_CellContentClick;
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
            Column2.HeaderText = "Id";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 49;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Nama Alat Pertanian";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Harga";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 77;
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
            // V_TambahLayanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "V_TambahLayanan";
            Size = new Size(1185, 970);
            Load += V_TambahLayanan_Load;
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel4;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dgvLay;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Edit;
    }
}
