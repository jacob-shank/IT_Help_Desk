using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmAdminDashboard : Form
    {
        string username_;
        Session mySession_;
        char userType;
        public frmAdminDashboard(Session mySession)
        {
            mySession_ = mySession;
            InitializeComponent();

            userType = mySession.UserType();
            //usertypeBox.Text = mySession.UserType();

            lblUsername.Text += mySession.getUser().getUsername();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void adminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProjectMember_Click(object sender, EventArgs e)
        {
            frmProjectMemberDashboard PMDash = new frmProjectMemberDashboard(mySession_);
            PMDash.Show();
            this.Hide();
            this.Dispose();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpPage myHelp = new HelpPage(mySession_);
            myHelp.Show();
            this.Hide();
            this.Dispose();
        }
        private void btnITDashboard_Click(object sender, EventArgs e)
        {
            frmITDashboard IT = new frmITDashboard(mySession_);
            IT.Show();
            this.Hide();
            this.Dispose();
        }
        private void btnReportManager_Click(object sender, EventArgs e)
        {
            frmReportManagerDash newDash = new frmReportManagerDash(mySession_);
            newDash.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin newLogin = new frmLogin();
            newLogin.Show();
            this.Hide();
            this.Dispose();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnPermCodes_Click(object sender, EventArgs e)
        {
            frmUserTypeCodes permCodesFrm = new frmUserTypeCodes(mySession_);
            permCodesFrm.Show();
            this.Hide();
            this.Dispose();
        }
    }

}