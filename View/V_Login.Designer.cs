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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            button_login = new Button();
            button1 = new Button();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.Location = new Point(151, 228);
            UsernameBox.Margin = new Padding(2);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(515, 37);
            UsernameBox.TabIndex = 2;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.Location = new Point(151, 315);
            PasswordBox.Margin = new Padding(2);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(515, 37);
            PasswordBox.TabIndex = 6;
            // 
            // button_login
            // 
            button_login.BackColor = Color.ForestGreen;
            button_login.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.GreenYellow;
            button_login.Location = new Point(141, 410);
            button_login.Margin = new Padding(2);
            button_login.Name = "button_login";
            button_login.Size = new Size(238, 44);
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
            button1.Location = new Point(462, 410);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(238, 44);
            button1.TabIndex = 7;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.Transparent;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = Color.Transparent;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.InitialImage = (Image)resources.GetObject("guna2PictureBox1.InitialImage");
            guna2PictureBox1.Location = new Point(66, -321);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(657, 887);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 8;
            guna2PictureBox1.TabStop = false;
            guna2PictureBox1.UseTransparentBackground = true;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2022_10_27_at_13_22_01;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            Controls.Add(guna2PictureBox1);
            Controls.Add(button1);
            Controls.Add(button_login);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "V_Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button button_login;
        private Button button1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
