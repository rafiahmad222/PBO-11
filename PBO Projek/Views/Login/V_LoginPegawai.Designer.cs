namespace PBO_Projek.Views
{
    partial class V_LoginOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LoginOwner));
            checkBox1 = new CheckBox();
            button1 = new Button();
            panel1 = new Panel();
            textPassword = new TextBox();
            panel2 = new Panel();
            Username = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(324, 218);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(47, 257);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(393, 42);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 250, 250);
            panel1.Controls.Add(textPassword);
            panel1.Location = new Point(47, 166);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 42);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(250, 250, 250);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textPassword.ForeColor = Color.Black;
            textPassword.Location = new Point(14, 10);
            textPassword.Margin = new Padding(3, 2, 3, 2);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(365, 21);
            textPassword.TabIndex = 2;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 250, 250);
            panel2.Controls.Add(Username);
            panel2.Location = new Point(47, 106);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 42);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(250, 250, 250);
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.Black;
            Username.Location = new Point(14, 10);
            Username.Margin = new Padding(3, 2, 3, 2);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(365, 21);
            Username.TabIndex = 2;
            Username.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(18, 15);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(35, 30);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // V_LoginOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_LoginOwner";
            Size = new Size(495, 370);
            Load += V_LoginOwner_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Button button1;
        private Panel panel1;
        private TextBox textPassword;
        private Panel panel2;
        private TextBox Username;
        private Button button2;
    }
}
