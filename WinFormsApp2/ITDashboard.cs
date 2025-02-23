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
    public partial class frmITDashboard : Form
    {
        Session Session_;
        public frmITDashboard(Session mySession)
        {
            InitializeComponent();
            this.Session_ = mySession;
            this.create_listBox1();

            lblUsername.Text += Session_.getUser().getUsername();

            btnHome.Visible = false;
            if (Session_.UserType() == 'A')
            {
                btnHome.Visible = true;

            }
            if (Session_.UserType()== 'A')
            {
                this.create_Admin();
                lblTitle.Text = "All Assigned Tickets";
            }
            else
            {
                this.create_listBox1();
            }
        }
        private void create_listBox1()
        {
            listBox1.Items.Clear();
            List<string> info = Session_.showAllTicketsIT_MEMBER(cbxIncludeClosed.Checked);
            for (int i = 0; i < info.Count; i++)
            {
                listBox1.Items.Add(info[i]);
            }
        }
        private void create_Admin()
        {
            listBox1.Items.Clear();
            List<string> info = Session_.showAllTickets(cbxIncludeClosed.Checked);
            for (int i = 0; i < info.Count; i++)
            {
                listBox1.Items.Add(info[i]);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int digits = 0;
            List<string> myResponse = new List<string>();
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (selectedItem.Length >= 2 && char.IsDigit(selectedItem[0]) && char.IsDigit(selectedItem[1]))
                {
                    string firstTwoChars = selectedItem.Substring(0, 3);

                    digits = int.Parse(firstTwoChars);
                }
                string response = Session_.getInfo(digits);
                TicketInfo display = new TicketInfo(response, Session_, digits);
                //MessageBox.Show(digits.ToString());
                display.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void ITDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin newLogin = new frmLogin();
            newLogin.Show();
            this.Dispose();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Session_.UserType() == 'A')
            {
                frmAdminDashboard newAdminDash = new frmAdminDashboard(Session_);
                this.Dispose();
                newAdminDash.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (Session_.UserType() == 'A')
            {
                btnRefresh.Hide();
                create_Admin();
                btnRefresh.Show();
            }
            else
            {
                btnRefresh.Hide();
                create_listBox1();
                btnRefresh.Show();
            }
        }

        private void cbxIncludeClosed_CheckedChanged(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }
    }
}
