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
    //sess
    public partial class TicketForm : Form
    {
        public frmLogin myLogin;
        string username_;
        Session Session_;
        //string priority_;
        Database TicketDB = new Database();
        public TicketForm(/*string priority,*/ Session session)
        {
            //priority_ = priority;
            Session_ = session;
            username_ = Session_.getUser().getUsername();

            InitializeComponent();

        }

        private void btnCloseTicketForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(username_);
            string userCreated = username_;
            string subject = txtSubject.Text;
            string description = txtIssue.Text;

            if (subject.Equals(""))
            {
                MessageBox.Show("Please Enter a Subject");
            }
            else if (description.Equals(""))
            {
                MessageBox.Show("Please Enter a Description");
            }
            else if (cboUrgency.Text.Equals(""))
            {
                MessageBox.Show("Please Choose an Urgency");
            }
            else
            {
                //get the priority, since it hasn't been parsed yet
                char priority = cboUrgency.Text.ToCharArray()[0];

                int response = TicketDB.CreateTicket(userCreated, priority, subject, description);

                if (response == -1)
                {
                    MessageBox.Show("Enter a valid ugrency.");
                }
                else if (response == -2)
                {
                    MessageBox.Show("Subject has too many characters.");
                }
                else if (response == -3)
                {
                    MessageBox.Show("Description has too many characters.");
                }
                else
                {
                    MessageBox.Show("Your ticket has been sent! We will get to you shortly. Thank you.");
                    this.Dispose();

                    //don't take them anywhere, because we left their old dash board open
                }
            }



            //MessageBox.Show(TicketDB.CreateTicket(userCreated, priority, subject, description).ToString());
            //MessageBox.Show("Ticket submitted successfully!");


        }

        private void TicketForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIssue_TextChanged(object sender, EventArgs e)
        {

        }
        private void TicketCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblUrgency_Click(object sender, EventArgs e)
        {

        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }
    }
}
