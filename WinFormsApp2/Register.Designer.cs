namespace Registration_Page
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            lblUser = new Label();
            lblLN = new Label();
            lblEmail = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            btnReg = new Button();
            pictureBox1 = new PictureBox();
            txtConfirmPass = new TextBox();
            lblConfirmPassword = new Label();
            lblUserTypeCode = new Label();
            txtUserTypeCode = new TextBox();
            lblUserTaken = new Label();
            lblPassDoNotMatch = new Label();
            btnUserCodeHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Microsoft Tai Le", 14F);
            lblUser.ForeColor = Color.Black;
            lblUser.Location = new Point(215, 110);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(99, 23);
            lblUser.TabIndex = 0;
            lblUser.Text = "Username:";
            lblUser.UseWaitCursor = true;
            lblUser.Click += lblFN_Click;
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.BackColor = Color.Transparent;
            lblLN.Font = new Font("Microsoft Tai Le", 14F);
            lblLN.ForeColor = Color.Black;
            lblLN.Location = new Point(220, 145);
            lblLN.Margin = new Padding(2, 0, 2, 0);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(94, 23);
            lblLN.TabIndex = 1;
            lblLN.Text = "Password:";
            lblLN.Click += label2_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Microsoft Tai Le", 14F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(252, 215);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblUserType_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Microsoft Tai Le", 14F);
            txtUser.Location = new Point(318, 108);
            txtUser.Margin = new Padding(2);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(240, 31);
            txtUser.TabIndex = 4;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.White;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Microsoft Tai Le", 14F);
            txtPass.Location = new Point(318, 143);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(240, 31);
            txtPass.TabIndex = 5;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Tai Le", 14F);
            txtEmail.Location = new Point(318, 213);
            txtEmail.Margin = new Padding(4, 2, 4, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 31);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.IndianRed;
            btnReg.BackgroundImageLayout = ImageLayout.None;
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.FlatStyle = FlatStyle.Popup;
            btnReg.Font = new Font("Microsoft Tai Le", 14F);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(433, 284);
            btnReg.Margin = new Padding(4, 2, 4, 2);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(125, 37);
            btnReg.TabIndex = 10;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-501, -60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 671);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BackColor = Color.White;
            txtConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPass.Font = new Font("Microsoft Tai Le", 14F);
            txtConfirmPass.Location = new Point(318, 178);
            txtConfirmPass.Margin = new Padding(2);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(240, 31);
            txtConfirmPass.TabIndex = 12;
            txtConfirmPass.TextChanged += txtConfirmPass_TextChanged;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Microsoft Tai Le", 14F);
            lblConfirmPassword.ForeColor = Color.Black;
            lblConfirmPassword.Location = new Point(147, 180);
            lblConfirmPassword.Margin = new Padding(2, 0, 2, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(167, 23);
            lblConfirmPassword.TabIndex = 13;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblUserTypeCode
            // 
            lblUserTypeCode.AutoSize = true;
            lblUserTypeCode.BackColor = Color.Transparent;
            lblUserTypeCode.Font = new Font("Microsoft Tai Le", 14F);
            lblUserTypeCode.ForeColor = Color.Black;
            lblUserTypeCode.Location = new Point(165, 251);
            lblUserTypeCode.Name = "lblUserTypeCode";
            lblUserTypeCode.Size = new Size(146, 23);
            lblUserTypeCode.TabIndex = 14;
            lblUserTypeCode.Text = "User Type Code:";
            lblUserTypeCode.Click += label1_Click;
            // 
            // txtUserTypeCode
            // 
            txtUserTypeCode.BackColor = Color.White;
            txtUserTypeCode.BorderStyle = BorderStyle.FixedSingle;
            txtUserTypeCode.Font = new Font("Microsoft Tai Le", 14F);
            txtUserTypeCode.Location = new Point(318, 249);
            txtUserTypeCode.Margin = new Padding(4, 2, 4, 2);
            txtUserTypeCode.Name = "txtUserTypeCode";
            txtUserTypeCode.Size = new Size(240, 31);
            txtUserTypeCode.TabIndex = 15;
            txtUserTypeCode.TextChanged += txtUserTypeCode_TextChanged;
            // 
            // lblUserTaken
            // 
            lblUserTaken.AutoSize = true;
            lblUserTaken.Font = new Font("Microsoft Tai Le", 14F);
            lblUserTaken.ForeColor = Color.IndianRed;
            lblUserTaken.Location = new Point(563, 110);
            lblUserTaken.Name = "lblUserTaken";
            lblUserTaken.Size = new Size(208, 23);
            lblUserTaken.TabIndex = 16;
            lblUserTaken.Text = "Username not avalaible";
            // 
            // lblPassDoNotMatch
            // 
            lblPassDoNotMatch.AutoSize = true;
            lblPassDoNotMatch.Font = new Font("Microsoft Tai Le", 14F);
            lblPassDoNotMatch.ForeColor = Color.IndianRed;
            lblPassDoNotMatch.Location = new Point(563, 180);
            lblPassDoNotMatch.Name = "lblPassDoNotMatch";
            lblPassDoNotMatch.Size = new Size(215, 23);
            lblPassDoNotMatch.TabIndex = 17;
            lblPassDoNotMatch.Text = "Passwords do not match";
            // 
            // btnUserCodeHelp
            // 
            btnUserCodeHelp.BackColor = Color.White;
            btnUserCodeHelp.BackgroundImageLayout = ImageLayout.None;
            btnUserCodeHelp.FlatAppearance.BorderSize = 0;
            btnUserCodeHelp.FlatStyle = FlatStyle.Popup;
            btnUserCodeHelp.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserCodeHelp.ForeColor = Color.Black;
            btnUserCodeHelp.Location = new Point(566, 249);
            btnUserCodeHelp.Margin = new Padding(4, 2, 4, 2);
            btnUserCodeHelp.Name = "btnUserCodeHelp";
            btnUserCodeHelp.Size = new Size(34, 31);
            btnUserCodeHelp.TabIndex = 18;
            btnUserCodeHelp.Text = "?";
            btnUserCodeHelp.UseVisualStyleBackColor = false;
            btnUserCodeHelp.Click += btnUserCodeHelp_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUserCodeHelp);
            Controls.Add(lblPassDoNotMatch);
            Controls.Add(lblUserTaken);
            Controls.Add(txtUserTypeCode);
            Controls.Add(lblUserTypeCode);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPass);
            Controls.Add(btnReg);
            Controls.Add(txtEmail);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblEmail);
            Controls.Add(lblLN);
            Controls.Add(lblUser);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblLN;
        private Label lblEmail;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtEmail;
        private Button btnReg;
        private PictureBox pictureBox1;
        private TextBox txtConfirmPass;
        private Label lblConfirmPassword;
        private Label lblUserTypeCode;
        private TextBox txtUserTypeCode;
        private Label lblUserTaken;
        private Label lblPassDoNotMatch;
        private Button btnUserCodeHelp;
    }
}
