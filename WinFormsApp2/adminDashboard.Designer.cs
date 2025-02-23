namespace WinFormsApp2
{
    partial class frmAdminDashboard
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
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);*/
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            btnProjectMember = new Button();
            btnHelp = new Button();
            btnReportManager = new Button();
            button2 = new Button();
            btnITDashboard = new Button();
            pnlPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTitle = new Label();
            lblUsername = new Label();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            btnPermCodes = new Button();
            pnlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProjectMember
            // 
            btnProjectMember.BackColor = Color.IndianRed;
            btnProjectMember.FlatAppearance.BorderSize = 0;
            btnProjectMember.FlatStyle = FlatStyle.Popup;
            btnProjectMember.Font = new Font("Microsoft Tai Le", 14F);
            btnProjectMember.ForeColor = Color.White;
            btnProjectMember.Location = new Point(395, 401);
            btnProjectMember.Name = "btnProjectMember";
            btnProjectMember.Size = new Size(125, 37);
            btnProjectMember.TabIndex = 2;
            btnProjectMember.Text = "Tickets";
            btnProjectMember.UseVisualStyleBackColor = false;
            btnProjectMember.Click += btnProjectMember_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.IndianRed;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Popup;
            btnHelp.Font = new Font("Microsoft Tai Le", 14F);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(655, 401);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(125, 37);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnReportManager
            // 
            btnReportManager.BackColor = Color.IndianRed;
            btnReportManager.FlatAppearance.BorderColor = Color.FromArgb(226, 182, 196);
            btnReportManager.FlatAppearance.BorderSize = 0;
            btnReportManager.FlatStyle = FlatStyle.Popup;
            btnReportManager.Font = new Font("Microsoft Tai Le", 14F);
            btnReportManager.ForeColor = Color.White;
            btnReportManager.Location = new Point(264, 401);
            btnReportManager.Name = "btnReportManager";
            btnReportManager.Size = new Size(125, 37);
            btnReportManager.TabIndex = 14;
            btnReportManager.Text = "Manager";
            btnReportManager.UseVisualStyleBackColor = false;
            btnReportManager.Click += btnReportManager_Click;
            // 
            // button2
            // 
            button2.Location = new Point(614, 518);
            button2.Name = "button2";
            button2.Size = new Size(91, 75);
            button2.TabIndex = 15;
            button2.Text = "IT Help Desk";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnITDashboard
            // 
            btnITDashboard.BackColor = Color.IndianRed;
            btnITDashboard.FlatStyle = FlatStyle.Popup;
            btnITDashboard.Font = new Font("Microsoft Tai Le", 14F);
            btnITDashboard.ForeColor = Color.White;
            btnITDashboard.Location = new Point(525, 401);
            btnITDashboard.Name = "btnITDashboard";
            btnITDashboard.Size = new Size(125, 37);
            btnITDashboard.TabIndex = 15;
            btnITDashboard.Text = "IT Help Desk";
            btnITDashboard.UseVisualStyleBackColor = false;
            btnITDashboard.Click += btnITDashboard_Click;
            // 
            // pnlPanel
            // 
            pnlPanel.BackColor = Color.White;
            pnlPanel.BorderStyle = BorderStyle.FixedSingle;
            pnlPanel.Controls.Add(label3);
            pnlPanel.Controls.Add(label2);
            pnlPanel.Controls.Add(label1);
            pnlPanel.Controls.Add(lblTitle);
            pnlPanel.Location = new Point(84, 88);
            pnlPanel.Name = "pnlPanel";
            pnlPanel.Size = new Size(697, 301);
            pnlPanel.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Tai Le", 14F);
            label3.Location = new Point(-1, 69);
            label3.Name = "label3";
            label3.Size = new Size(259, 23);
            label3.TabIndex = 24;
            label3.Text = "If you are lost just select help!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Tai Le", 14F);
            label2.Location = new Point(-1, 46);
            label2.Name = "label2";
            label2.Size = new Size(453, 23);
            label2.TabIndex = 23;
            label2.Text = "Selecting IT Help Desk will display help desk abilities.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Tai Le", 14F);
            label1.Location = new Point(-1, 23);
            label1.Name = "label1";
            label1.Size = new Size(402, 23);
            label1.TabIndex = 22;
            label1.Text = "Selecting tickets will display your active tickets.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Microsoft Tai Le", 14F);
            lblTitle.Location = new Point(-1, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(476, 23);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Selecting manager will display report manager settings.";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.FlatStyle = FlatStyle.Flat;
            lblUsername.Font = new Font("Microsoft Tai Le", 27F);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(84, 44);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(122, 45);
            lblUsername.TabIndex = 18;
            lblUsername.Text = "Hello, ";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(655, 43);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 36);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-501, -60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 671);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnPermCodes
            // 
            btnPermCodes.BackColor = Color.IndianRed;
            btnPermCodes.FlatAppearance.BorderColor = Color.FromArgb(226, 182, 196);
            btnPermCodes.FlatAppearance.BorderSize = 0;
            btnPermCodes.FlatStyle = FlatStyle.Popup;
            btnPermCodes.Font = new Font("Microsoft Tai Le", 14F);
            btnPermCodes.ForeColor = Color.White;
            btnPermCodes.Location = new Point(84, 401);
            btnPermCodes.Name = "btnPermCodes";
            btnPermCodes.Size = new Size(174, 37);
            btnPermCodes.TabIndex = 21;
            btnPermCodes.Text = "Permission Codes";
            btnPermCodes.UseVisualStyleBackColor = false;
            btnPermCodes.Click += btnPermCodes_Click;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPermCodes);
            Controls.Add(btnLogout);
            Controls.Add(pnlPanel);
            Controls.Add(lblUsername);
            Controls.Add(btnHelp);
            Controls.Add(btnReportManager);
            Controls.Add(btnITDashboard);
            Controls.Add(btnProjectMember);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosing += adminDashboard_FormClosing;
            Load += frmAdminDashboard_Load;
            pnlPanel.ResumeLayout(false);
            pnlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnProjectMember;
        private Button btnHelp;
        private Button btnReportManager;
        private Button button2;
        private Button btnITDashboard;
        private Panel pnlPanel;
        private Label lblUsername;
        private Button btnLogout;
        private Label lblTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnPermCodes;
    }
}