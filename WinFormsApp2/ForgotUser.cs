using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmForgotUser : Form
    {
        Database database_;
        public frmForgotUser()
        {
            InitializeComponent();
            database_ = new Database();
        }

        private void forgotUser_FormClosing(object sener, EventArgs e)
        {
            this.Dispose();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input your the email connected to your account, and we'll let you know what your username is.");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = database_.forgotUsername(email);

            if (username.Equals(""))
            {
                MessageBox.Show("Invalid Email.");
            }
            else
            {
                btnSubmit.Enabled = false;
                Cursor = Cursors.WaitCursor;

                string message = "Hello User. You requested an email to recover your username. \n\nUsername: " + username + "\nPlease do not reply to this message.\n\nRegards,\nGugul Development Team :)";
                var client = new SmtpClient("smtp.gmail.com");
                client.Credentials = new NetworkCredential("smtpe07@gmail.com", "eozdttcopxyxjnwx");
                client.Port = 587;
                client.EnableSsl = true;
                client.Send("smtpe07@gmail.com", email, "Password Request", message);
                Cursor = Cursors.Default;
                MessageBox.Show("Successfully sent to: " + email);
                this.Dispose();
            }
        }
    }
}
