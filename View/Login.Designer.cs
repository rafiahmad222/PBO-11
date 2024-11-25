namespace PBO_Projek
{
    partial class Login
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 557);
            panel1.TabIndex = 0;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Creato Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(444, 119);
            Username.Name = "Username";
            Username.Size = new Size(125, 29);
            Username.TabIndex = 1;
            Username.Text = "Username:";
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.Location = new Point(447, 152);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(554, 37);
            UsernameBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(447, 268);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(554, 37);
            PasswordBox.TabIndex = 4;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Creato Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(445, 234);
            Password.Name = "Password";
            Password.Size = new Size(121, 29);
            Password.TabIndex = 3;
            Password.Text = "Password:";
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Font = new Font("SF Pro Display", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPassword.Location = new Point(836, 311);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(165, 28);
            ShowPassword.TabIndex = 5;
            ShowPassword.Text = "Show Password";
            ShowPassword.UseVisualStyleBackColor = true;
            // 
            // button_login
            // 
            button_login.Font = new Font("Helotypo", 10.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_login.Location = new Point(621, 402);
            button_login.Name = "button_login";
            button_login.Size = new Size(237, 44);
            button_login.TabIndex = 6;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 552);
            Controls.Add(button_login);
            Controls.Add(ShowPassword);
            Controls.Add(PasswordBox);
            Controls.Add(Password);
            Controls.Add(UsernameBox);
            Controls.Add(Username);
            Controls.Add(panel1);
            Name = "Login";
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
    }
}
