namespace Final_Indv_Assg___Work_Tasks_by_Nuno
{
    partial class Login_Form
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
            tbxUsername = new TextBox();
            btnLogin = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            lblCredits = new Label();
            picBxLogo = new PictureBox();
            lblTitle = new Label();
            tbxPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picBxLogo).BeginInit();
            SuspendLayout();
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxUsername.Location = new Point(164, 141);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(336, 25);
            tbxUsername.TabIndex = 0;
            tbxUsername.Text = "admin";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(203, 236);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(207, 26);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(73, 193);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 17);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(73, 144);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(79, 17);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // lblCredits
            // 
            lblCredits.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCredits.AutoSize = true;
            lblCredits.Location = new Point(516, 293);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(65, 17);
            lblCredits.TabIndex = 5;
            lblCredits.Text = "By N4fta";
            // 
            // picBxLogo
            // 
            picBxLogo.Image = Properties.Resources.Taskmaster_Marvel_Logo;
            picBxLogo.Location = new Point(-24, -5);
            picBxLogo.Name = "picBxLogo";
            picBxLogo.Size = new Size(119, 115);
            picBxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picBxLogo.TabIndex = 6;
            picBxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Rockwell", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(203, 69);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(207, 32);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Taskmaster";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbxPassword.Location = new Point(164, 190);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(336, 25);
            tbxPassword.TabIndex = 8;
            tbxPassword.Text = "admin";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 319);
            Controls.Add(tbxPassword);
            Controls.Add(lblTitle);
            Controls.Add(picBxLogo);
            Controls.Add(lblCredits);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            Controls.Add(tbxUsername);
            Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(609, 358);
            Name = "Login_Form";
            Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)picBxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Button btnLogin;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblCredits;
        private PictureBox picBxLogo;
        private Label lblTitle;
    }
}