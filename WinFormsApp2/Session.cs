using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Mail;


namespace WinFormsApp2
{
    public class Session
    {
        private Database Database_;
        private User User_;
        private string username_;
        private string receiveEmail; 

        public Session(string UserString)
        {
            Database_ = new Database();
            username_= UserString;
            User_ = new User(UserString, Database_);
        }
        public User getUser() { return User_; }

        public List<string> getTickets(bool getClosed)
        {
            return Database_.getTicketsAssignedToUserAsString(User_.getUsername(), getClosed);
        }
        public List<string> showAllTickets(bool getClosed)
        {
            return Database_.getAllTickets(getClosed);
        }
        //MODIFY TO GET IT TICKETS
        public List<string> showAllTicketsIT_MEMBER(bool getClosed)
        {
            return Database_.getAllTicketsIT(User_.getUsername(), getClosed);
        }
        public string getInfo(int IDNumber)
        {
            return Database_.AllInfo(IDNumber);
        }
        public List<string> getVectorInformation(int IDNumber)
        {
            return Database_.vectorAllInfo(IDNumber);
        }
        public void updateticketId(int IDNumber, char priority)
        {
            Database_.UpdateTicket(IDNumber,' ',"",priority,"","","");
        }
        public char UserType()
        {
            return User_.getUsertype();
           
        }
        public List<string> getIT()
        {
            return Database_.getAllITMembers();
        }
        public bool updateAssignment(string User, int ID)
        {
            bool ans = Database_.AddAssignment(ID, User);
            return ans;
        }
        public void submitResponse(int ID, string Response)
        {
            Database_.UpdateTicketResponseAndStatus(ID, Response);
            string subjectVal = Database_.getSubject(ID);
            receiveEmail = Database_.getEmail(ID);
            Email(Response, subjectVal, ID);
        }
        public void Open(int ID)
        {
            Database_.ReOpen(ID);
        }
        public void Email(string response, string subjectVal, int ID)
        {

            // Message Body
            string message = "Response to Ticket " + ID + ":\n\t" + response + "\n\nTicket solved by: " + User_.getUsername();
            // Message Subject Line
            string subject = "IT Help Ticket Response: "+ subjectVal;
            // Sender's Email Address
            string sender = "smtpe07@gmail.com";
            // 2FA Application One Time Password
            string password = "eozdttcopxyxjnwx";
            // Receiver's Email Address
            string receiver = receiveEmail;
            SmtpClient emailClient = new SmtpClient("smtp.gmail.com");
            emailClient.Credentials = new NetworkCredential(sender, password);
            emailClient.Port = 587;
            emailClient.EnableSsl = true;
            emailClient.Send(sender, receiver, subject, message);
        }
    }

}
