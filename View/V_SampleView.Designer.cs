namespace PBO_Projek.View
{
    partial class V_SampleView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            brnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            label2 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = Properties.Resources.gala_search;
            txtSearch.IconLeftSize = new Size(30, 30);
            txtSearch.Location = new Point(710, 90);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderForeColor = Color.Silver;
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(324, 44);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(710, 60);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // brnAdd
            // 
            brnAdd.BackColor = Color.Transparent;
            brnAdd.CheckedState.ImageSize = new Size(64, 64);
            brnAdd.HoverState.ImageSize = new Size(64, 64);
            brnAdd.Image = Properties.Resources.icon_park_add;
            brnAdd.ImageOffset = new Point(0, 0);
            brnAdd.ImageRotate = 0F;
            brnAdd.ImageSize = new Size(84, 84);
            brnAdd.Location = new Point(53, 60);
            brnAdd.Name = "brnAdd";
            brnAdd.PressedState.ImageSize = new Size(64, 64);
            brnAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            brnAdd.Size = new Size(96, 81);
            brnAdd.TabIndex = 2;
            brnAdd.UseTransparentBackground = true;
            brnAdd.Click += brnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(36, 20);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 3;
            label2.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(36, 170);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(998, 15);
            guna2Separator1.TabIndex = 4;
            // 
            // V_SampleView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1047, 586);
            Controls.Add(guna2Separator1);
            Controls.Add(label2);
            Controls.Add(brnAdd);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_SampleView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_SampleView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        public Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Label label1;
        public Guna.UI2.WinForms.Guna2ImageButton brnAdd;
    }
}