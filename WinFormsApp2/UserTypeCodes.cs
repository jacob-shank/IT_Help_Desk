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
    public partial class frmUserTypeCodes : Form
    {
        private Session session_;
        public frmUserTypeCodes(Session session)
        {
            InitializeComponent();

            session_ = session;

            lblUsername.Text += session_.getUser().getUsername();

        }

        private void userTypeCodes_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminDashboard newAdminDash = new frmAdminDashboard(session_);
            newAdminDash.Show();
            this.Dispose();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin newLogin = new frmLogin();
            newLogin.Show();
            this.Dispose();
        }

        private void btnUserCodeHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giving one of these codes to an employee will allow them to register an account with the given permission level. \nEmployees can register an account with no permission code, and they will be registered as a project member.");
        }

        private void lblAdminPermCode_Click(object sender, EventArgs e)
        {
            frmUserTypeCodesCheck passForm = new frmUserTypeCodesCheck(session_,'A');
            passForm.Show();
        }

        private void lblITPermCode_Click(object sender, EventArgs e)
        {
            frmUserTypeCodesCheck passForm = new frmUserTypeCodesCheck(session_, 'I');
            passForm.Show();
        }

        private void lblRMPermCode_Click(object sender, EventArgs e)
        {
            frmUserTypeCodesCheck passForm = new frmUserTypeCodesCheck(session_, 'R');
            passForm.Show();
        }
    }
}
