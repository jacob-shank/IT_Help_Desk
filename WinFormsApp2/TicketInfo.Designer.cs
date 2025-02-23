namespace WinFormsApp2
{
    partial class TicketInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketInfo));
            btnLogout = new Button();
            lblMyTickets = new Label();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(613, 34);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 36);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Priority";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblMyTickets
            // 
            lblMyTickets.AutoSize = true;
            lblMyTickets.Font = new Font("Microsoft Tai Le", 27F);
            lblMyTickets.ForeColor = Color.Black;
            lblMyTickets.ImeMode = ImeMode.NoControl;
            lblMyTickets.Location = new Point(56, 25);
            lblMyTickets.Name = "lblMyTickets";
            lblMyTickets.Size = new Size(82, 45);
            lblMyTickets.TabIndex = 22;
            lblMyTickets.Text = "Info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-501, -60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 671);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Microsoft Tai Le", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(56, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(682, 347);
            listBox1.TabIndex = 24;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(482, 34);
            button1.Name = "button1";
            button1.Size = new Size(125, 36);
            button1.TabIndex = 25;
            button1.Text = "Respond";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(613, 73);
            button2.Name = "button2";
            button2.Size = new Size(125, 36);
            button2.TabIndex = 26;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(613, 384);
            button3.Name = "button3";
            button3.Size = new Size(125, 36);
            button3.TabIndex = 27;
            button3.Text = "Reopen";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TicketInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblMyTickets);
            Controls.Add(btnLogout);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TicketInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket Info";
            Load += TicketInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogout;
        private Label lblMyTickets;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}