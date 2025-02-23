namespace WinFormsApp2
{
    partial class frmUserTypeCodesCheck
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
            lblEnterPassword = new Label();
            txtPassword = new TextBox();
            btnSubmit = new Button();
            lblIncorrectPassword = new Label();
            SuspendLayout();
            // 
            // lblEnterPassword
            // 
            lblEnterPassword.AutoSize = true;
            lblEnterPassword.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterPassword.Location = new Point(12, 19);
            lblEnterPassword.Name = "lblEnterPassword";
            lblEnterPassword.Size = new Size(212, 46);
            lblEnterPassword.TabIndex = 0;
            lblEnterPassword.Text = "Enter Password to View \r\nPermission Code:\r\n";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Microsoft Tai Le", 14F);
            txtPassword.Location = new Point(12, 70);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(240, 31);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.IndianRed;
            btnSubmit.BackgroundImageLayout = ImageLayout.None;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Microsoft Tai Le", 14F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(66, 143);
            btnSubmit.Margin = new Padding(4, 2, 4, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 39);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblIncorrectPassword
            // 
            lblIncorrectPassword.AutoSize = true;
            lblIncorrectPassword.Font = new Font("Microsoft Tai Le", 14F);
            lblIncorrectPassword.ForeColor = Color.IndianRed;
            lblIncorrectPassword.Location = new Point(50, 106);
            lblIncorrectPassword.Name = "lblIncorrectPassword";
            lblIncorrectPassword.Size = new Size(170, 23);
            lblIncorrectPassword.TabIndex = 17;
            lblIncorrectPassword.Text = "Incorrect Password";
            // 
            // frmUserTypeCodesCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(270, 194);
            Controls.Add(lblIncorrectPassword);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword);
            Controls.Add(lblEnterPassword);
            Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmUserTypeCodesCheck";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnterPassword;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Label lblIncorrectPassword;
    }
}