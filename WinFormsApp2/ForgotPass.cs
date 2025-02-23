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
    public partial class frmForgotPass : Form
    {
        private User user_;
        Database database_;
        public frmForgotPass()
        {
            InitializeComponent();
            database_ = new Database();
        }
        private void btnForgotPassGo_Click(object sender, EventArgs e)
        {
            btnReg.Enabled = false;
            Cursor = Cursors.WaitCursor;
            string userForgotPass = txbForgotPassEmailForm.Text;
            List<string> items = database_.forgotPassword(userForgotPass);
            if (!items[0].Equals(""))
            {
                //send email
                string message = "Hello User " + userForgotPass + "!\n\nYour password: " + items[1] + "\nPlease do not reply to this message.\n\nRegards,\nGugul Development Team :)";
                var client = new SmtpClient("smtp.gmail.com");
                client.Credentials = new NetworkCredential("smtpe07@gmail.com", "eozdttcopxyxjnwx");
                client.Port = 587;
                client.EnableSsl = true;
                client.Send("smtpe07@gmail.com", items[0], "Password Request", message);
                Cursor = Cursors.Default;
                MessageBox.Show("Successfully sent to: " + items[0]);
                this.Dispose();
            }
            else
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Username is invalid.");
                btnReg.Enabled = true;
            }
        }
        private void forgotPass_FormClosing(object sener, EventArgs e)
        {
            this.Dispose();
        }

        private void txbForgotPassEmailForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input your username, and we'll automatically send and email so you can view your password.");
        }
    }
}
