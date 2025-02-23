namespace WinFormsApp2
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            lblSubject = new Label();
            txtSubject = new TextBox();
            txtIssue = new RichTextBox();
            label1 = new Label();
            btnSubmit = new Button();
            lblUrgency = new Label();
            cboUrgency = new ComboBox();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.BackColor = Color.Transparent;
            lblSubject.Font = new Font("Microsoft Tai Le", 14F);
            lblSubject.ForeColor = Color.Black;
            lblSubject.Location = new Point(56, 9);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(72, 23);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Subject";
            lblSubject.Click += lblSubject_Click;
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.White;
            txtSubject.BorderStyle = BorderStyle.FixedSingle;
            txtSubject.Font = new Font("Microsoft Tai Le", 14F);
            txtSubject.ForeColor = Color.Black;
            txtSubject.Location = new Point(154, 7);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(240, 31);
            txtSubject.TabIndex = 3;
            txtSubject.TextChanged += txtSubject_TextChanged;
            // 
            // txtIssue
            // 
            txtIssue.BackColor = Color.White;
            txtIssue.BorderStyle = BorderStyle.FixedSingle;
            txtIssue.Font = new Font("Microsoft Tai Le", 14F);
            txtIssue.ForeColor = Color.Black;
            txtIssue.Location = new Point(56, 73);
            txtIssue.Name = "txtIssue";
            txtIssue.Size = new Size(682, 322);
            txtIssue.TabIndex = 5;
            txtIssue.Text = "";
            txtIssue.TextChanged += txtIssue_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 14F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(56, 49);
            label1.Name = "label1";
            label1.Size = new Size(192, 23);
            label1.TabIndex = 6;
            label1.Text = "Explain Your Problem";
            label1.Click += label1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.IndianRed;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Microsoft Tai Le", 14F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(613, 401);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 37);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblUrgency
            // 
            lblUrgency.AutoSize = true;
            lblUrgency.BackColor = Color.Transparent;
            lblUrgency.Font = new Font("Microsoft Tai Le", 14F);
            lblUrgency.ForeColor = Color.Black;
            lblUrgency.Location = new Point(56, 405);
            lblUrgency.Name = "lblUrgency";
            lblUrgency.Size = new Size(80, 23);
            lblUrgency.TabIndex = 19;
            lblUrgency.Text = "Urgency";
            lblUrgency.Click += lblUrgency_Click;
            // 
            // cboUrgency
            // 
            cboUrgency.FlatStyle = FlatStyle.Flat;
            cboUrgency.Font = new Font("Microsoft Tai Le", 14F);
            cboUrgency.ForeColor = Color.Black;
            cboUrgency.FormattingEnabled = true;
            cboUrgency.Items.AddRange(new object[] { "Urgent Priority", "High Priority", "Medium Priority", "Low Priority" });
            cboUrgency.Location = new Point(154, 402);
            cboUrgency.Name = "cboUrgency";
            cboUrgency.Size = new Size(240, 31);
            cboUrgency.TabIndex = 20;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Tai Le", 14F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(478, 401);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 37);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(663, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 36);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnCancel);
            Controls.Add(cboUrgency);
            Controls.Add(lblUrgency);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtIssue);
            Controls.Add(txtSubject);
            Controls.Add(lblSubject);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TicketForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Ticket";
            FormClosing += TicketCreator_FormClosing;
            Load += TicketForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSubject;
        private TextBox txtSubject;
        private RichTextBox txtIssue;
        private Label label1;
        private Button btnSubmit;
        private Label lblUrgency;
        private ComboBox cboUrgency;
        private Button btnCancel;
        private PictureBox pictureBox1;
        private Button btnLogout;
    }
}