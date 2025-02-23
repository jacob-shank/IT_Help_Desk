using WinFormsApp2;

namespace Registration_Page
{
    public partial class Register : Form
    {
        Database myDatabase = new Database();

        public Register()
        {
            InitializeComponent();
            //Database myDatabase;

            lblUserTaken.Hide();
            lblPassDoNotMatch.Hide();
        }

        private void SaveInfoToDatabase(string username, string password, char usertype, string email)
        {

            bool success = myDatabase.Register(username, password, usertype, email);

            if (success)
            {
                //close form
                MessageBox.Show("Account successfully registered.");
                this.Close();
            }
            else
            {
                //do not close form
                MessageBox.Show("Username not available.");
                txtUser.Clear();
                txtPass.Clear();
                txtConfirmPass.Clear();
                txtEmail.Clear();
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void lblFN_Click(object sender, EventArgs e)
        {


        }
        private char usertype;
        private void btnReg_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            string codeUT = txtUserTypeCode.Text;
            if (codeUT.Equals("4H8437UIL"))
            {
                usertype = 'A';
            }
            else if (codeUT.Equals("7JIY64502E"))
            {
                usertype = 'I';
            }
            else if (codeUT.Equals("3YI938Y641"))
            {
                usertype = 'R';
            }
            else if (codeUT.Equals(""))
            {
                usertype = 'P';
            }
            else
            {
                MessageBox.Show("Invalid User Type Code.");
                txtUserTypeCode.Clear();
                return;
            }


            string email = txtEmail.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Please Enter a Username");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Please Enter a Password");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("Please Enter an Email");
            }
            else
            {
                //make sure they properly confirmed their password
                if (txtPass.Text.Equals(txtConfirmPass.Text))
                {
                    SaveInfoToDatabase(username, password, usertype, email);
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                    txtPass.Clear();
                    txtConfirmPass.Clear();
                }

            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPass.Clear();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (myDatabase.IsDuplicateString("U_ser", "Username", txtUser.Text))
            {
                lblUserTaken.Show();
            }
            else
            {
                lblUserTaken.Hide();
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (!txtPass.Text.Equals(txtConfirmPass.Text))
            {
                lblPassDoNotMatch.Show();
            }
            else
            {
                lblPassDoNotMatch.Hide();
            }
        }

        private void txtUser_Type_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm1Bkg_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserTypeCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUserCodeHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you were given a code to determine your account permission level, input it here. Otherwise, leave this box blank.");
        }
    }
}


//IT Help Desk User Type Code: 4H8437UIL
//Report Manager User Type Code: 7JIY64502E
//Project Member User Type Code: 3YI938Y641