namespace WinFormsApp2
{
    partial class frmUserTypeCodes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserTypeCodes));
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            btnHome = new Button();
            btnLogout = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            lblRMPermCode = new Label();
            lblITPermCode = new Label();
            lblAdminPermCode = new Label();
            btnUserCodeHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-501, -60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 671);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(59, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(53, 21);
            lblUsername.TabIndex = 25;
            lblUsername.Text = "Hello, ";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.IndianRed;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(532, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(125, 36);
            btnHome.TabIndex = 29;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(663, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 36);
            btnLogout.TabIndex = 28;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Tai Le", 27F);
            lblTitle.Location = new Point(59, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 45);
            lblTitle.TabIndex = 30;
            lblTitle.Text = "Permission Codes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblRMPermCode);
            panel1.Controls.Add(lblITPermCode);
            panel1.Controls.Add(lblAdminPermCode);
            panel1.Location = new Point(59, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 303);
            panel1.TabIndex = 31;
            // 
            // lblRMPermCode
            // 
            lblRMPermCode.AutoSize = true;
            lblRMPermCode.Cursor = Cursors.Hand;
            lblRMPermCode.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRMPermCode.Location = new Point(36, 178);
            lblRMPermCode.Name = "lblRMPermCode";
            lblRMPermCode.Size = new Size(339, 23);
            lblRMPermCode.TabIndex = 2;
            lblRMPermCode.Text = "View Report Manager Permission Code";
            lblRMPermCode.Click += lblRMPermCode_Click;
            // 
            // lblITPermCode
            // 
            lblITPermCode.AutoSize = true;
            lblITPermCode.Cursor = Cursors.Hand;
            lblITPermCode.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblITPermCode.Location = new Point(36, 125);
            lblITPermCode.Name = "lblITPermCode";
            lblITPermCode.Size = new Size(344, 23);
            lblITPermCode.TabIndex = 1;
            lblITPermCode.Text = "View IT Team Member Permission Code";
            lblITPermCode.Click += lblITPermCode_Click;
            // 
            // lblAdminPermCode
            // 
            lblAdminPermCode.AutoSize = true;
            lblAdminPermCode.Cursor = Cursors.Hand;
            lblAdminPermCode.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAdminPermCode.Location = new Point(36, 71);
            lblAdminPermCode.Name = "lblAdminPermCode";
            lblAdminPermCode.Size = new Size(257, 23);
            lblAdminPermCode.TabIndex = 0;
            lblAdminPermCode.Text = "View Admin Permission Code";
            lblAdminPermCode.Click += lblAdminPermCode_Click;
            // 
            // btnUserCodeHelp
            // 
            btnUserCodeHelp.BackColor = Color.White;
            btnUserCodeHelp.BackgroundImageLayout = ImageLayout.None;
            btnUserCodeHelp.FlatAppearance.BorderSize = 0;
            btnUserCodeHelp.FlatStyle = FlatStyle.Popup;
            btnUserCodeHelp.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserCodeHelp.ForeColor = Color.Black;
            btnUserCodeHelp.Location = new Point(366, 55);
            btnUserCodeHelp.Margin = new Padding(4, 2, 4, 2);
            btnUserCodeHelp.Name = "btnUserCodeHelp";
            btnUserCodeHelp.Size = new Size(34, 31);
            btnUserCodeHelp.TabIndex = 19;
            btnUserCodeHelp.Text = "?";
            btnUserCodeHelp.UseVisualStyleBackColor = false;
            btnUserCodeHelp.Click += btnUserCodeHelp_Click;
            // 
            // frmUserTypeCodes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUserCodeHelp);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Controls.Add(btnHome);
            Controls.Add(btnLogout);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUserTypeCodes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permission Codes";
            FormClosing += userTypeCodes_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FrmForgotPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private PictureBox pictureBox1;
        private Label lblUsername;
        private Button btnHome;
        private Button btnLogout;
        private Label lblTitle;
        private Panel panel1;
        private Label lblRMPermCode;
        private Label lblITPermCode;
        private Label lblAdminPermCode;
        private Button btnUserCodeHelp;
    }
}