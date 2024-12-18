namespace PBO_Projek.Views
{
    partial class V_LoginPemilik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LoginPemilik));
            textPassword = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            Username = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(250, 250, 250);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textPassword.ForeColor = Color.Black;
            textPassword.Location = new Point(16, 14);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(417, 28);
            textPassword.TabIndex = 2;
            textPassword.TextChanged += textBox2_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 250, 250);
            panel1.Controls.Add(textPassword);
            panel1.Location = new Point(40, 205);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 56);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(40, 327);
            button1.Name = "button1";
            button1.Size = new Size(449, 56);
            button1.TabIndex = 4;
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
            button2.Location = new Point(20, 20);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(357, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 250, 250);
            panel2.Controls.Add(Username);
            panel2.Location = new Point(40, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 56);
            panel2.TabIndex = 9;
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(250, 250, 250);
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.Black;
            Username.Location = new Point(16, 14);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(417, 28);
            Username.TabIndex = 2;
            // 
            // V_LoginPemilik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "V_LoginPemilik";
            Size = new Size(529, 413);
            Load += V_LoginPemilik_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textPassword;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Panel panel2;
        public TextBox Username;
    }
}
