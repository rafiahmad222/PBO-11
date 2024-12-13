namespace PBO_Projek
{
    partial class V_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Username = new Label();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            Password = new Label();
            ShowPassword = new CheckBox();
            button_login = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.BackgroundImage = Properties.Resources.fotor_20241128145441;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 446);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.GreenYellow;
            Username.Location = new Point(438, 95);
            Username.Margin = new Padding(2, 0, 2, 0);
            Username.Name = "Username";
            Username.Size = new Size(112, 24);
            Username.TabIndex = 1;
            Username.Text = "Username:";
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.Location = new Point(438, 122);
            UsernameBox.Margin = new Padding(2);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(329, 32);
            UsernameBox.TabIndex = 2;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(438, 213);
            PasswordBox.Margin = new Padding(2);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(329, 32);
            PasswordBox.TabIndex = 4;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.GreenYellow;
            Password.Location = new Point(438, 186);
            Password.Margin = new Padding(2, 0, 2, 0);
            Password.Name = "Password";
            Password.Size = new Size(110, 24);
            Password.TabIndex = 3;
            Password.Text = "Password:";
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.BackColor = Color.Transparent;
            ShowPassword.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPassword.ForeColor = Color.GreenYellow;
            ShowPassword.Location = new Point(616, 249);
            ShowPassword.Margin = new Padding(2);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(158, 23);
            ShowPassword.TabIndex = 5;
            ShowPassword.Text = "Show Password";
            ShowPassword.UseVisualStyleBackColor = false;
            // 
            // button_login
            // 
            button_login.BackColor = Color.ForestGreen;
            button_login.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.GreenYellow;
            button_login.Location = new Point(516, 326);
            button_login.Margin = new Padding(2);
            button_login.Name = "button_login";
            button_login.Size = new Size(190, 35);
            button_login.TabIndex = 6;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.GreenYellow;
            button1.Location = new Point(516, 365);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(190, 35);
            button1.TabIndex = 7;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2022_10_27_at_13_22_01;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(837, 442);
            Controls.Add(button1);
            Controls.Add(button_login);
            Controls.Add(ShowPassword);
            Controls.Add(PasswordBox);
            Controls.Add(Password);
            Controls.Add(UsernameBox);
            Controls.Add(Username);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "V_Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Username;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Label Password;
        private CheckBox ShowPassword;
        private Button button_login;
        private Button button1;
    }
}
