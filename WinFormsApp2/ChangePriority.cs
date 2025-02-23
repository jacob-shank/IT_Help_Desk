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
    public partial class ChangePriority : Form
    {
        Session newSession_;
        int myId_;
        public ChangePriority(Session session, int ticketId)
        {
            InitializeComponent();
            newSession_ = session;
            myId_ = ticketId;
            create_listBox1();
        }
        private void ChangePriority_Load(object sender, EventArgs e)
        {

        }
        private void create_listBox1()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < newSession_.getIT().Count; i++)
            {
                listBox1.Items.Add(newSession_.getIT()[i]);
            }

        }






        private void button1_Click(object sender, EventArgs e)
        {
            newSession_.updateticketId(myId_, 'L');
            MessageBox.Show("Changed priority of the ticket to Low");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            newSession_.updateticketId(myId_, 'M');
            MessageBox.Show("Changed priority of the ticket to Medium");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newSession_.updateticketId(myId_, 'H');
            MessageBox.Show("Changed priority of the ticket to High");
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            newSession_.updateticketId(myId_, 'U');
            MessageBox.Show("Changed priority of the ticket to Urgent");
            this.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.Items[listBox1.SelectedIndex].ToString();
            int firstSpaceIndex = selectedItem.IndexOf(' ');

            if (firstSpaceIndex != -1)
            {
                selectedItem = selectedItem.Substring(0, firstSpaceIndex);
            }
            bool ans = newSession_.updateAssignment(selectedItem, myId_);
            if (ans == true)
            {
                MessageBox.Show("Successfully added " + selectedItem);
            }
            else
            {
                MessageBox.Show("Failed!");
            }
        }

        private void lblMyTickets_Click(object sender, EventArgs e)
        {

        }
    }
}
