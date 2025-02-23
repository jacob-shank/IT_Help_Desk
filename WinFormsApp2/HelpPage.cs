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
    public partial class HelpPage : Form
    {
        Session Session_;
        public HelpPage(Session mySession)
        {
            InitializeComponent();
            Session_ = mySession;

            lblUsername.Text += Session_.getUser().getUsername();

        }

        private void HelpPage_Load(object sender, EventArgs e)
        {

        }
        private void HelpPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            frmAdminDashboard newDash = new frmAdminDashboard(Session_);
            newDash.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnTickHome_Click(object sender, EventArgs e)
        {
            frmAdminDashboard myDash = new frmAdminDashboard(Session_);
            this.Dispose();
            myDash.Show();
        }

        private void tsmHome_Click(object sender, EventArgs e)
        {
            frmAdminDashboard myDash = new frmAdminDashboard(Session_);
            this.Dispose();
            myDash.Show();
        }

        private void tsmLogOut_Click(object sender, EventArgs e)
        {
            frmLogin newlogin = new frmLogin();
            newlogin.Show();
            this.Dispose();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin mylogin = new frmLogin();
            mylogin.Show();
            this.Dispose();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(Session_.UserType() == 'A')
            {
                frmAdminDashboard newAdminDash = new frmAdminDashboard(Session_);
                newAdminDash.Show();
                this.Dispose();
            }
        }
    }
}
