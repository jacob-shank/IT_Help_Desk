namespace WinFormsApp2
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            btnClear = new Button();
            lblForgotUser = new LinkLabel();
            lblForgotPass = new LinkLabel();
            lblPass = new Label();
            pnlBackground = new Panel();
            lblIncorrectUserPass = new Label();
            lblTitle = new Label();
            pbxLogo = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft Tai Le", 14F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(18, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(358, 31);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Tai Le", 14F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(18, 145);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(358, 31);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Microsoft Tai Le", 14F);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(18, 33);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(95, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(11, 19, 43);
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(243, 217, 220);
            lblPassword.Location = new Point(578, 403);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 15);
            lblPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(204, 83, 86);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Microsoft Tai Le", 14F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(532, 368);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 37);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Submit";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(204, 83, 86);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Segoe UI", 14F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(663, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 37);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblForgotUser
            // 
            lblForgotUser.AutoSize = true;
            lblForgotUser.BackColor = Color.Transparent;
            lblForgotUser.Font = new Font("Microsoft Tai Le", 14F);
            lblForgotUser.LinkColor = Color.Black;
            lblForgotUser.Location = new Point(212, 189);
            lblForgotUser.Name = "lblForgotUser";
            lblForgotUser.Size = new Size(164, 23);
            lblForgotUser.TabIndex = 10;
            lblForgotUser.TabStop = true;
            lblForgotUser.Text = "Forgot Username?";
            lblForgotUser.LinkClicked += lblForgotUser_LinkClicked;
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.BackColor = Color.Transparent;
            lblForgotPass.Font = new Font("Microsoft Tai Le", 14F);
            lblForgotPass.LinkColor = Color.Black;
            lblForgotPass.Location = new Point(18, 189);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(159, 23);
            lblForgotPass.TabIndex = 11;
            lblForgotPass.TabStop = true;
            lblForgotPass.Text = "Forgot Password?";
            lblForgotPass.LinkClicked += lblForgotPass_LinkClicked;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.White;
            lblPass.FlatStyle = FlatStyle.System;
            lblPass.Font = new Font("Microsoft Tai Le", 14F);
            lblPass.ForeColor = Color.Black;
            lblPass.Location = new Point(23, 113);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(90, 23);
            lblPass.TabIndex = 16;
            lblPass.Text = "Password";
            // 
            // pnlBackground
            // 
            pnlBackground.BackColor = Color.White;
            pnlBackground.BorderStyle = BorderStyle.FixedSingle;
            pnlBackground.Controls.Add(lblIncorrectUserPass);
            pnlBackground.Controls.Add(lblPass);
            pnlBackground.Controls.Add(lblUsername);
            pnlBackground.Controls.Add(txtUsername);
            pnlBackground.Controls.Add(txtPassword);
            pnlBackground.Controls.Add(lblForgotPass);
            pnlBackground.Controls.Add(lblForgotUser);
            pnlBackground.Location = new Point(399, 92);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(389, 258);
            pnlBackground.TabIndex = 17;
            // 
            // lblIncorrectUserPass
            // 
            lblIncorrectUserPass.AutoSize = true;
            lblIncorrectUserPass.BackColor = Color.Transparent;
            lblIncorrectUserPass.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncorrectUserPass.ForeColor = Color.FromArgb(204, 83, 86);
            lblIncorrectUserPass.Location = new Point(58, 225);
            lblIncorrectUserPass.Name = "lblIncorrectUserPass";
            lblIncorrectUserPass.Size = new Size(287, 23);
            lblIncorrectUserPass.TabIndex = 17;
            lblIncorrectUserPass.Text = "Incorrect Username or Password.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Tai Le", 27F);
            lblTitle.Location = new Point(399, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(108, 45);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Login";
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.Gugul_Text_Logo_Cut_L;
            pbxLogo.Location = new Point(-15, -44);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(522, 542);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 18;
            pbxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 27F);
            label1.Location = new Point(28, 206);
            label1.Name = "label1";
            label1.Size = new Size(190, 45);
            label1.TabIndex = 21;
            label1.Text = "New User?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(204, 83, 86);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Tai Le", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(93, 294);
            button1.Name = "button1";
            button1.Size = new Size(125, 37);
            button1.TabIndex = 22;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(38, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(236, 123);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lblPassword);
            Controls.Add(pnlBackground);
            Controls.Add(pbxLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            FormClosing += frmLogin_FormClosing;
            pnlBackground.ResumeLayout(false);
            pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnClear;
        private LinkLabel lblForgotUser;
        private LinkLabel lblForgotPass;
        private Label lblPass;
        private Panel pnlBackground;
        private PictureBox pbxLogo;
        private Label lblTitle;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Label lblIncorrectUserPass;
    }
}
