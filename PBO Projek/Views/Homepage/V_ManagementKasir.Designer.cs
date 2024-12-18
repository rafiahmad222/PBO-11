namespace PBO_Projek.Views.Homepage
{
    partial class V_ManagementKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ManagementKasir));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnAdd = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            txtsKas = new TextBox();
            label2 = new Label();
            dgvKasir = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Hapus = new DataGridViewImageColumn();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKasir).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(971, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 28);
            btnAdd.TabIndex = 2;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dgvKasir);
            panel3.Location = new Point(400, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(479, 491);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(txtsKas);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 441);
            panel4.Name = "panel4";
            panel4.Size = new Size(479, 50);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(343, 10);
            button2.Name = "button2";
            button2.Size = new Size(122, 30);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // txtsKas
            // 
            txtsKas.Location = new Point(98, 13);
            txtsKas.Name = "txtsKas";
            txtsKas.Size = new Size(168, 27);
            txtsKas.TabIndex = 1;
            txtsKas.TextChanged += textBox1_TextChanged;
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
            // dgvKasir
            // 
            dgvKasir.AllowUserToAddRows = false;
            dgvKasir.AllowUserToDeleteRows = false;
            dgvKasir.AllowUserToResizeColumns = false;
            dgvKasir.AllowUserToResizeRows = false;
            dgvKasir.BackgroundColor = Color.White;
            dgvKasir.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LimeGreen;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKasir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKasir.ColumnHeadersHeight = 35;
            dgvKasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvKasir.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column4, Password, Edit, Hapus });
            dgvKasir.Dock = DockStyle.Top;
            dgvKasir.EnableHeadersVisualStyles = false;
            dgvKasir.Location = new Point(0, 0);
            dgvKasir.Name = "dgvKasir";
            dgvKasir.RowHeadersVisible = false;
            dgvKasir.RowHeadersWidth = 51;
            dgvKasir.Size = new Size(479, 576);
            dgvKasir.TabIndex = 0;
            dgvKasir.CellContentClick += dgvKasir_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 49;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Nama Kasir";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Username";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 102;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 97;
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
            // Hapus
            // 
            Hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Hapus.HeaderText = "";
            Hapus.Image = (Image)resources.GetObject("Hapus.Image");
            Hapus.MinimumWidth = 6;
            Hapus.Name = "Hapus";
            Hapus.Width = 6;
            // 
            // V_ManagementKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "V_ManagementKasir";
            Size = new Size(1185, 970);
            Load += V_ManagementTeknisi_Load;
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKasir).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtsKas;
        private Label label2;
        public DataGridView dgvKasir;
        private Button button2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Hapus;
    }
}
