namespace WinFormsApp2
{
    partial class frmForgotUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotUser));
            txtEmail = new TextBox();
            lblLN = new Label();
            btnSubmit = new Button();
            pictureBox1 = new PictureBox();
            btnUserCodeHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Tai Le", 14F);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(276, 181);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 31);
            txtEmail.TabIndex = 4;
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.BackColor = Color.Transparent;
            lblLN.Font = new Font("Microsoft Tai Le", 14F);
            lblLN.ForeColor = Color.Black;
            lblLN.Location = new Point(211, 186);
            lblLN.Margin = new Padding(2, 0, 2, 0);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(60, 23);
            lblLN.TabIndex = 7;
            lblLN.Text = "Email:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.IndianRed;
            btnSubmit.BackgroundImageLayout = ImageLayout.None;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Microsoft Tai Le", 14F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(391, 223);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 37);
            btnSubmit.TabIndex = 12;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-501, -60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 671);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnUserCodeHelp
            // 
            btnUserCodeHelp.BackColor = Color.White;
            btnUserCodeHelp.BackgroundImageLayout = ImageLayout.None;
            btnUserCodeHelp.FlatAppearance.BorderSize = 0;
            btnUserCodeHelp.FlatStyle = FlatStyle.Popup;
            btnUserCodeHelp.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserCodeHelp.ForeColor = Color.Black;
            btnUserCodeHelp.Location = new Point(523, 181);
            btnUserCodeHelp.Margin = new Padding(4, 2, 4, 2);
            btnUserCodeHelp.Name = "btnUserCodeHelp";
            btnUserCodeHelp.Size = new Size(34, 31);
            btnUserCodeHelp.TabIndex = 21;
            btnUserCodeHelp.Text = "?";
            btnUserCodeHelp.UseVisualStyleBackColor = false;
            btnUserCodeHelp.Click += btnHelp_Click;
            // 
            // frmForgotUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUserCodeHelp);
            Controls.Add(pictureBox1);
            Controls.Add(btnSubmit);
            Controls.Add(lblLN);
            Controls.Add(txtEmail);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmForgotUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Username";
            FormClosing += forgotUser_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private Label lblLN;
        private Button btnSubmit;
        private PictureBox pictureBox1;
        private Button btnUserCodeHelp;
    }
}