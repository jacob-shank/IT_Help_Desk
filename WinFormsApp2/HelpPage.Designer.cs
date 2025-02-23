namespace WinFormsApp2
{
    partial class HelpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPage));
            btnCanvas = new Button();
            btnVMHelp = new Button();
            btnVS = new Button();
            listBox1 = new ListBox();
            btnLogout = new Button();
            lblMyTickets = new Label();
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCanvas
            // 
            btnCanvas.BackColor = Color.IndianRed;
            btnCanvas.FlatAppearance.BorderSize = 0;
            btnCanvas.FlatStyle = FlatStyle.Popup;
            btnCanvas.Font = new Font("Microsoft Tai Le", 14F);
            btnCanvas.ForeColor = Color.White;
            btnCanvas.Location = new Point(354, 401);
            btnCanvas.Name = "btnCanvas";
            btnCanvas.Size = new Size(125, 37);
            btnCanvas.TabIndex = 1;
            btnCanvas.Text = "Canvas";
            btnCanvas.UseVisualStyleBackColor = false;
            // 
            // btnVMHelp
            // 
            btnVMHelp.BackColor = Color.IndianRed;
            btnVMHelp.FlatAppearance.BorderSize = 0;
            btnVMHelp.FlatStyle = FlatStyle.Popup;
            btnVMHelp.Font = new Font("Microsoft Tai Le", 14F);
            btnVMHelp.ForeColor = Color.White;
            btnVMHelp.Location = new Point(485, 401);
            btnVMHelp.Name = "btnVMHelp";
            btnVMHelp.Size = new Size(125, 37);
            btnVMHelp.TabIndex = 2;
            btnVMHelp.Text = "VM";
            btnVMHelp.UseVisualStyleBackColor = false;
            // 
            // btnVS
            // 
            btnVS.BackColor = Color.IndianRed;
            btnVS.FlatAppearance.BorderSize = 0;
            btnVS.FlatStyle = FlatStyle.Popup;
            btnVS.Font = new Font("Microsoft Tai Le", 14F);
            btnVS.ForeColor = Color.White;
            btnVS.Location = new Point(616, 401);
            btnVS.Name = "btnVS";
            btnVS.Size = new Size(125, 37);
            btnVS.TabIndex = 3;
            btnVS.Text = "VS";
            btnVS.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Microsoft Tai Le", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(59, 91);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(682, 301);
            listBox1.TabIndex = 4;
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
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblMyTickets
            // 
            lblMyTickets.AutoSize = true;
            lblMyTickets.Font = new Font("Microsoft Tai Le", 27F);
            lblMyTickets.ForeColor = Color.Black;
            lblMyTickets.Location = new Point(59, 43);
            lblMyTickets.Name = "lblMyTickets";
            lblMyTickets.Size = new Size(418, 45);
            lblMyTickets.TabIndex = 21;
            lblMyTickets.Text = "Explore Help Links Below";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-501, -60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 671);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
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
            btnHome.TabIndex = 28;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // HelpPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHome);
            Controls.Add(lblUsername);
            Controls.Add(lblMyTickets);
            Controls.Add(btnLogout);
            Controls.Add(btnVMHelp);
            Controls.Add(btnVS);
            Controls.Add(btnCanvas);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HelpPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportManagerDash";
            FormClosing += HelpPage_FormClosing;
            Load += HelpPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCanvas;
        private Button btnVMHelp;
        private Button btnVS;
        private ListBox listBox1;
        private Button btnLogout;
        private Label lblMyTickets;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private Button btnHome;
    }
}