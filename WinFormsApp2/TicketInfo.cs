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
    public partial class TicketInfo : Form
    {
        Session session_;
        string info_;
        int ID_;
        char userType;
        public TicketInfo(string info, Session session, int ID)
        {
            session_ = session;
            info_ = info;
            ID_ = ID;
            InitializeComponent();
            userType = session.UserType();
            create_listBox1();

            //usertypeBox.Text = mySession.UserType();


            if (userType == 'P')
            {
                button1.Hide();
                btnLogout.Hide();
            }
        }

        private void TicketInfo_Load(object sender, EventArgs e)
        {
            //lblInfo.Text = info_;
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ChangePriority priority_change = new ChangePriority(session_, ID_);
            priority_change.Show();
            priority_change.Left = this.Left + 23;
            priority_change.Top = this.Top + 23;
        }

        private void create_listBox1()
        {
            List<string> info = session_.getVectorInformation(ID_);
            listBox1.Items.Clear();
            for (int i = 0; i < info.Count; i++)
            {
                listBox1.Items.Add(info[i]);
            }
            button3.Show();
            if (info[0].Trim().Equals("Status: Opened"))
            {
                button3.Hide();
            }
            lblMyTickets.Text = "Info for Ticket: " + info[1].Substring(15);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                //MessageBox.Show(listBox1.SelectedItem.ToString(), "", c BoxButtons.OK);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Response myResponse = new Response(session_, ID_);
            myResponse.Show();
            myResponse.Left = this.Left + 23;
            myResponse.Top = this.Top + 23;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
            create_listBox1();
            button2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            session_.Open(ID_);
            button2_Click(sender, e);
        }
    }
}
