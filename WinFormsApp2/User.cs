using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class User
    {
        /*public string Username { get; set; }
        public string Usertype { get; set; }
        public string Email { get; set; }

        public User(string User, Database database)
        {
            Username = User;
            Usertype = database.initializeUser(User,0);
            Email = database.initializeUser(User, 1);
        }*/

        private string Username_;
        private char Usertype_;
        private string Email_;
        private string Password_;

        public User(string User, Database database)
        {
            Username_ = User;
            Usertype_ = database.initializeUser(User, 0).ToCharArray()[0]; //idk why c# doesn't just have a charAt() smh
            Email_ = database.initializeUser(User, 1);
            Password_ = database.initializeUser(User, 2);
        }

        public string getUsername() { return Username_; }
        public string getEmail() { return Email_; }
        public char getUsertype() { return Usertype_;}
        
        public string getPassword() { return Password_; }


    }
}
