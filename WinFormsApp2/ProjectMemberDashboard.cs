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
    public partial class frmProjectMemberDashboard : Form
    {
        string username_;
        int ticket_category = 0;
        Session Session_;
        public frmProjectMemberDashboard(Session Session)
        {
            Session_ = Session;
            username_ = Session_.getUser().getUsername();
            InitializeComponent();
            create_listBox1();

            btnHome.Visible = false;
            if (Session_.UserType() == 'A' || Session_.UserType() == 'I')
            {
                btnHome.Visible = true;
            }

            lblUsername.Text += Session_.getUser().getUsername();

        }
        private void create_listBox1()
        {
            listBox1.Items.Clear();
            List<string> info = Session_.getTickets(cbxIncludeClosed.Checked);
            for (int i = 0; i < info.Count; i++)
            {
                listBox1.Items.Add(info[i]);
            }

        }

        private void btnTicketClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void OpenTicketForm()
        {

            // Instantiate ticketForm.cs
            TicketForm ticketFormInstance = new TicketForm(Session_);
            ticketFormInstance.Show();
            this.Dispose();
        }

        private void TicketCreator_Load(object sender, EventArgs e)
        {

        }
        private void TicketCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                display.Show();
            }
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCreateTicket_Click_1(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm(Session_);
            //this.Hide();
            ticketForm.Show();
            this.WindowState = FormWindowState.Minimized;
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
            else if (Session_.UserType() == 'I')
            {
                frmITDashboard newITDash = new frmITDashboard(Session_);
                this.Dispose();
                newITDash.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Hide();
            create_listBox1();
            btnRefresh.Show();
        }

        private void cbxIncludeClosed_CheckedChanged(object sender, EventArgs e)
        {
            btnRefresh_Click(sender, e);
        }
    }
}
