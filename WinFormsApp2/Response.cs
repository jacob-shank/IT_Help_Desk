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
    public partial class Response : Form
    {
        Session session;
        int ID_;
        public Response(Session session_, int ID)
        {
            InitializeComponent();
            session = session_;
            ID_ = ID;
            lblTitle.Text = "Responding to Ticket: " + ID_;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string description = txtIssue.Text;
            if (description.Equals(""))
            {
                MessageBox.Show("Provide a Response.");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                btnSubmit.Enabled = false;
                session.submitResponse(ID_, description);
                Cursor.Current = Cursors.Default;
                this.Close();
            }
        }
    }
}
