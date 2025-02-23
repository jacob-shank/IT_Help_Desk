

namespace WinFormsApp2
{
    partial class ChangePriority
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePriority));
            btnLow = new Button();
            btnMed = new Button();
            btnHigh = new Button();
            btnUrgent = new Button();
            listBox1 = new ListBox();
            lblMyTickets = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLow
            // 
            btnLow.BackColor = Color.IndianRed;
            btnLow.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLow, "btnLow");
            btnLow.ForeColor = Color.White;
            btnLow.Name = "btnLow";
            btnLow.UseVisualStyleBackColor = false;
            btnLow.Click += button1_Click;
            // 
            // btnMed
            // 
            btnMed.BackColor = Color.IndianRed;
            btnMed.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnMed, "btnMed");
            btnMed.ForeColor = Color.White;
            btnMed.Name = "btnMed";
            btnMed.UseVisualStyleBackColor = false;
            btnMed.Click += button2_Click;
            // 
            // btnHigh
            // 
            btnHigh.BackColor = Color.IndianRed;
            btnHigh.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnHigh, "btnHigh");
            btnHigh.ForeColor = Color.White;
            btnHigh.Name = "btnHigh";
            btnHigh.UseVisualStyleBackColor = false;
            btnHigh.Click += button3_Click;
            // 
            // btnUrgent
            // 
            btnUrgent.BackColor = Color.IndianRed;
            btnUrgent.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnUrgent, "btnUrgent");
            btnUrgent.ForeColor = Color.White;
            btnUrgent.Name = "btnUrgent";
            btnUrgent.UseVisualStyleBackColor = false;
            btnUrgent.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.Name = "listBox1";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblMyTickets
            // 
            resources.ApplyResources(lblMyTickets, "lblMyTickets");
            lblMyTickets.ForeColor = Color.Black;
            lblMyTickets.Name = "lblMyTickets";
            lblMyTickets.Click += lblMyTickets_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // ChangePriority
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(lblMyTickets);
            Controls.Add(listBox1);
            Controls.Add(btnUrgent);
            Controls.Add(btnHigh);
            Controls.Add(btnMed);
            Controls.Add(btnLow);
            Controls.Add(pictureBox1);
            Name = "ChangePriority";
            Load += ChangePriority_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnLow;
        private Button btnMed;
        private Button btnHigh;
        private Button btnUrgent;
        private ListBox listBox1;
        private Label lblMyTickets;
        private PictureBox pictureBox1;
    }
}