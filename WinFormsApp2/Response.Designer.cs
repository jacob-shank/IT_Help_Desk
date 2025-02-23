
namespace WinFormsApp2
{
    partial class Response
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Response));
            txtIssue = new RichTextBox();
            btnSubmit = new Button();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIssue
            // 
            txtIssue.BackColor = Color.White;
            txtIssue.BorderStyle = BorderStyle.FixedSingle;
            txtIssue.Font = new Font("Microsoft Tai Le", 14F);
            txtIssue.ForeColor = Color.Black;
            txtIssue.Location = new Point(59, 64);
            txtIssue.Name = "txtIssue";
            txtIssue.Size = new Size(682, 322);
            txtIssue.TabIndex = 6;
            txtIssue.Text = "";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.IndianRed;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Microsoft Tai Le", 14F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(616, 392);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 37);
            btnSubmit.TabIndex = 8;
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
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Microsoft Tai Le", 27F);
            lblTitle.Location = new Point(59, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(374, 45);
            lblTitle.TabIndex = 24;
            lblTitle.Text = "Responding to Ticket: \r\n";
            // 
            // Response
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnSubmit);
            Controls.Add(txtIssue);
            Controls.Add(pictureBox1);
            Name = "Response";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Response Writer";
            Load += Response_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Response_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private RichTextBox txtIssue;
        private Button btnSubmit;
        private PictureBox pictureBox1;
        private Label lblTitle;
    }
}