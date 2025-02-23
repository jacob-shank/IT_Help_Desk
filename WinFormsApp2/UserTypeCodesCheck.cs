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
    public partial class frmUserTypeCodesCheck : Form
    {
        Session session_;
        char userTypeToOpen_;
        Database database_;
        public frmUserTypeCodesCheck(Session session, char userTypeToOpen)
        {
            session_ = session;
            userTypeToOpen_ = userTypeToOpen;
            database_ = new Database();

            InitializeComponent();
            lblIncorrectPassword.Hide();

            this.TopMost = true;
            this.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (database_.Login(session_.getUser().getUsername(), txtPassword.Text))
            {
                if(userTypeToOpen_ == 'A')
                {
                    this.Hide();
                    this.Dispose();
                    MessageBox.Show("4H8437UIL");
                }
                else if(userTypeToOpen_ == 'I')
                {
                    this.Hide();
                    this.Dispose();
                    MessageBox.Show("7JIY64502E");
                }
                else if(userTypeToOpen_ == 'R')
                {
                    this.Hide();
                    this.Dispose();
                    MessageBox.Show("3YI938Y641");
                }
                else
                {
                    this.Hide();
                    this.Dispose();
                }
            }
            else
            {
                txtPassword.Clear();
                lblIncorrectPassword.Show();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblIncorrectPassword.Hide();
        }
    }
}
