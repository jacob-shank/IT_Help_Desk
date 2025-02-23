using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Timers;


/*
 * View list of unsolved tickets
 * System date comparison
 * Update priority
 * View report
 * Logout
 */

namespace WinFormsApp2
{
    public partial class frmReportManagerDash : Form
    {
        Session Session_;
        public frmReportManagerDash(Session session_)
        {
            InitializeComponent();
            Session_ = session_;
            create_listBox1();

            lblUsername.Text += Session_.getUser().getUsername();

            //listBox1.MouseDown += listBox1_MouseDown;

            /* System.Timers.Timer aTimer = new System.Timers.Timer();
             aTimer.Elapsed += new ElapsedEventHandler(create_listBox1);
             aTimer.Interval = 5000;
             aTimer.Enabled = true;

             Console.WriteLine("Press \'q\' to quit the sample.");
             while (Console.Read() != 'q') ;*/

            btnHome.Visible = false;
            if (Session_.UserType() == 'A' || Session_.UserType() == 'I')
            {
                btnHome.Visible = true;
            }

            cbxIncludeClosed.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ReportMangerDash_FormClosing(object sender, EventArgs r)
        {
            Application.Exit();

        }
        private void create_listBox1()
        {
            List<string> info = new List<string>();
            info = Session_.showAllTickets(cbxIncludeClosed.Checked);
            listBox1.Items.Clear();
            for (int i = 0; i < info.Count; i++)
            {
                listBox1.Items.Add(info[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
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
                Cursor = Cursors.Default;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBox1.IndexFromPoint(e.Location);
                if (index == 1)
                {
                    MessageBox.Show("Hello");
                }
            }
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
