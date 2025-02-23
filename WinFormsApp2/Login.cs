using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Devices;
using Registration_Page; 

namespace WinFormsApp2

{
    public partial class frmLogin : Form
    {
        Database connection_ = new Database();
        bool isWrong = false;
        public frmLogin()
        {

            InitializeComponent();
            lblIncorrectUserPass.Hide();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void frmLogin_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if the database login method says that the user and pass are in the database
            if (connection_.Login(txtUsername.Text, txtPassword.Text))
            {
                Session session = new Session(txtUsername.Text);

                if (session.UserType() == 'A') //goes to admin dashboard
                {
                    frmAdminDashboard adminDash = new frmAdminDashboard(session);
                    adminDash.Show();
                    this.Hide();
                }
                else if (session.UserType() == 'I')
                {
                    //MessageBox.Show(session.UserType().ToString());
                    frmITDashboard ITDash = new frmITDashboard(session);
                    ITDash.Show();
                    this.Hide();
                }
                else if (session.UserType() == 'R')
                {
                    frmReportManagerDash reportDashboard = new frmReportManagerDash(session);
                    reportDashboard.Show();
                    this.Hide();
                }
                else //UserType == P for project member
                {
                    //opens admin dashboard for now
                    frmProjectMemberDashboard tempPMDash = new frmProjectMemberDashboard(session);
                    tempPMDash.Show();
                    this.Hide();
                }
            }
            else
            {
                lblIncorrectUserPass.Show();
                isWrong = true;
                txtPassword.Clear();
            }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!isWrong)
            {
                lblIncorrectUserPass.Hide();
            }
            isWrong = false;
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!isWrong)
            {
                lblIncorrectUserPass.Hide();
            }
            isWrong = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /*int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);*/
        }

        private void lblForgotUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotUser forgotUser = new frmForgotUser();
            forgotUser.Show();
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPass forgotPass = new frmForgotPass();
            forgotPass.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Register newUser = new Register();
            newUser.Show();
        }
    }
}
