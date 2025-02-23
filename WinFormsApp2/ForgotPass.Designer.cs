namespace WinFormsApp2
{
    partial class frmForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPass));
            txbForgotPassEmailForm = new TextBox();
            lblLN = new Label();
            btnReg = new Button();
            pictureBox1 = new PictureBox();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txbForgotPassEmailForm
            // 
            txbForgotPassEmailForm.BackColor = Color.White;
            txbForgotPassEmailForm.BorderStyle = BorderStyle.FixedSingle;
            txbForgotPassEmailForm.Font = new Font("Microsoft Tai Le", 14F);
            txbForgotPassEmailForm.Location = new Point(309, 169);
            txbForgotPassEmailForm.Margin = new Padding(2);
            txbForgotPassEmailForm.MaximumSize = new Size(240, 31);
            txbForgotPassEmailForm.MinimumSize = new Size(240, 31);
            txbForgotPassEmailForm.Name = "txbForgotPassEmailForm";
            txbForgotPassEmailForm.Size = new Size(240, 31);
            txbForgotPassEmailForm.TabIndex = 3;
            txbForgotPassEmailForm.TextChanged += txbForgotPassEmailForm_TextChanged;
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.BackColor = Color.Transparent;
            lblLN.Font = new Font("Microsoft Tai Le", 14F);
            lblLN.ForeColor = Color.Black;
            lblLN.Location = new Point(206, 171);
            lblLN.Margin = new Padding(2, 0, 2, 0);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(99, 23);
            lblLN.TabIndex = 6;
            lblLN.Text = "Username:";
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.IndianRed;
            btnReg.BackgroundImageLayout = ImageLayout.None;
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.FlatStyle = FlatStyle.Popup;
            btnReg.Font = new Font("Microsoft Tai Le", 14F);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(424, 204);
            btnReg.Margin = new Padding(3, 2, 3, 2);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(125, 37);
            btnReg.TabIndex = 11;
            btnReg.Text = "Submit";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnForgotPassGo_Click;
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
            // btnHelp
            // 
            btnHelp.BackColor = Color.White;
            btnHelp.BackgroundImageLayout = ImageLayout.None;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Popup;
            btnHelp.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.ForeColor = Color.Black;
            btnHelp.Location = new Point(555, 169);
            btnHelp.Margin = new Padding(4, 2, 4, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(34, 31);
            btnHelp.TabIndex = 20;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // frmForgotPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHelp);
            Controls.Add(pictureBox1);
            Controls.Add(btnReg);
            Controls.Add(lblLN);
            Controls.Add(txbForgotPassEmailForm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmForgotPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            FormClosing += forgotPass_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FrmForgotPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TextBox txbForgotPassEmailForm;
        private Label lblLN;
        private Button btnReg;
        private PictureBox pictureBox1;
        private Button btnHelp;
    }
}