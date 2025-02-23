using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Random;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Reflection;
using System.Data.Common;

namespace WinFormsApp2
{
    public class Database
    {
        private string connectionString_;
        private SqlConnection connection_;
        private SqlDataReader reader_;
        public Database()
        {
            connectionString_ = "Server=tcp:se361server.database.windows.net,1433;Initial Catalog=ITHelpDesk;Persist Security Info=False;User ID=guguladmin;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection_ = new SqlConnection(connectionString_);
            try
            {
                connection_.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Opening Application");
                Application.Exit();
            }
        }
        ~Database()
        {
            reader_.Close();
        }

        public bool Login(string username, string password)
        {
            //string queryString = "SELECT * FROM [dbo].[U_ser] WHERE [U_ser].[Username] = \"" + username + "\' AND [U_ser].[Password] = \'" + password + "\';";

            string queryString = "SELECT * FROM [dbo].[U_ser] WHERE [U_ser].[Username] = '" + username + "' AND [U_ser].[Password] = '" + password + "';";

            SqlCommand cmd = new SqlCommand(queryString, connection_);

            reader_ = cmd.ExecuteReader();

            if (reader_.HasRows)
            {
                reader_.Close();
                return true;
            }
            else
            {
                reader_.Close();
                return false;
            }
        }
        //returns the primary key of the ticket just created. returns the opposite of the parameter "index" if the function failed. Leaves TicketResopne == NULL
        public int CreateTicket(string UserCreated, char Priority, string Subject, string Description)
        {
            int ticketID = 0;

            //check to make sure that everything fits the database restrictions
            //not going to check usercreated because it should have come from a session object which comes straight from the database at login, so it should be valid
            //if Priority does not indicate low, medium, hih, or urgent
            // if ((Priority!=('L')) || (!Priority.Equals('M')) || (!Priority.Equals('H')) || (!Priority.Equals('U')))
            if (Priority != 'L' && Priority != 'M' && Priority != 'H' && Priority != 'U')
            {
                return -1;
            }
            if (Subject.Length > 200)
            {
                return -2;
            }
            if (Description.Length > 1000)
            {
                return -3;
            }

            // connection_ = new SqlConnection(connectionString_Status is always 'O' for open
            string query = "INSERT INTO Ticket (Status,UserCreated,Priority,Subject,Description) VALUES (\'O\',\'" + UserCreated + "\',\'" + Priority + "\',\'" + Subject + "\',\'" + Description + "\')";

            SqlCommand command = new SqlCommand(query, connection_);

            if (command.ExecuteNonQuery() > 0)
            {
                SqlCommand tickIDcommand = new SqlCommand("SELECT TicketNum FROM Ticket ORDER BY TicketNum Desc;", connection_);
                string assignmentString = pickAssignment();
                reader_ = tickIDcommand.ExecuteReader();
                reader_.Read();

                //will be returned to show that it was complete
                ticketID = reader_.GetInt32(0);

                reader_.Close();

                //can do this because the ticket was already entered in the bool of the if
                AddAssignment(ticketID, assignmentString);

                return ticketID;
            }

            reader_.Close();

            //the query failed
            return 0;
        }

        public bool Register(string Username, string Password, char Usertype, string Email)
        {
            //first make sure that the user does not already exist in the table
            //checks to see if user has already been entered in column 0, using reader_'s command
            if (IsDuplicateString("U_ser", "Username", Username))
            {
                return false;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO U_ser (U_ser.Username, U_ser.Password, U_ser.Usertype, U_ser.Email) VALUES(\'" + Username + "\',\'" + Password + "\',\'" + Usertype + "\',\'" + Email + "\');", connection_);


            //now execute the command
            cmd.ExecuteNonQuery();

            return true;
        }

        public bool UpdateTicket(int TicketNum, char Status, string UserCreated, char Priority, string Subject, string Description, string TicketResponse)
        {
            bool StatusB = false, UserCreatedB = false, PriorityB = false, SubjectB = false, DescriptionB = false, TicketResponseB = false;

            //build the query depending on what parameters are present
            string query = "UPDATE Ticket SET";

            #region getBools

            //if status is intended to be updated
            if (Status != ' ')
            {
                StatusB = true;
            }
            //if user created is intended to be updates
            if (!UserCreated.Equals(""))
            {
                UserCreatedB = true;
            }
            if (Priority != ' ')
            {
                PriorityB = true;
            }
            if (!Subject.Equals(""))
            {
                SubjectB = true;
            }
            if (!Description.Equals(""))
            {
                DescriptionB = true;
            }
            if (!TicketResponse.Equals(""))
            {
                TicketResponseB = true;
            }

            #endregion getBools

            //now we know what parameters need to be added to the string. Had to get it in bools first to know where commas were needed

            //first, if none of the params are present, just return true
            if (!(StatusB || UserCreatedB || PriorityB || SubjectB || DescriptionB || TicketResponseB))
            {
                return true;
            }

            #region buildString

            //otherwise, build the query string one param at a time
            if (StatusB)
            {
                //first add the parameter for status
                query += " Status = \'" + Status + "\'";

                //now if there is another param coming, we need to add a comma
                if (UserCreatedB || PriorityB || SubjectB || DescriptionB || TicketResponseB)
                {
                    query += ",";
                }
            }
            if (UserCreatedB)
            {
                //first add the parameter for status
                query += " UserCreated = \'" + UserCreated + "\'";

                //now if there is another param coming, we need to add a comma
                if (PriorityB || SubjectB || DescriptionB || TicketResponseB)
                {
                    query += ",";
                }
            }
            if (PriorityB)
            {
                //first add the parameter for status
                query += " Priority = \'" + Priority + "\'";

                //now if there is another param coming, we need to add a comma
                if (SubjectB || DescriptionB || TicketResponseB)
                {
                    query += ",";
                }
            }
            if (SubjectB)
            {
                //first add the parameter for status
                query += " Subject = \'" + Subject + "\'";

                //now if there is another param coming, we need to add a comma
                if (DescriptionB || TicketResponseB)
                {
                    query += ",";
                }
            }
            if (DescriptionB)
            {
                //first add the parameter for status
                query += " Description = \'" + Description + "\'";

                //now if there is another param coming, we need to add a comma
                if (TicketResponseB)
                {
                    query += ",";
                }
            }
            if (TicketResponseB)
            {
                //first add the parameter for status
                query += " TicketResponse = \'" + TicketResponse + "\'";

                //there will never be a comma after TicketResponse
            }

            #endregion buildString

            //now add the where statement so that we target the right ticket
            query += " WHERE TicketNum = " + TicketNum + ";";

            //now build the SQL command and execute it
            SqlCommand cmd = new SqlCommand(query, connection_);

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //returns true when successful
        public bool UpdateUser(string Username, string Password, char Usertype, string Email)
        {
            bool PasswordB = false, UsertypeB = false, EmailB = false;

            //build the query depending on what parameters are present
            string query = "UPDATE U_ser SET";

            //if Password is intended to be updated
            if (!Password.Equals(""))
            {
                PasswordB = true;
            }
            //if user created is intended to be updates
            if (Usertype != ' ')
            {
                UsertypeB = true;
            }
            if (!Email.Equals(""))
            {
                EmailB = true;
            }

            //now we know what parameters need to be added to the string. Had to get it in bools first to know where commas were needed

            //first, if none of the params are present, just return true
            if (!(PasswordB || UsertypeB || EmailB))
            {
                return true;
            }

            #region buildString

            if (PasswordB)
            {
                //first add the parameter for Password
                query += " Password = \'" + Password + "\'";

                //now if there is another param coming, we need to add a comma
                if (UsertypeB || EmailB)
                {
                    query += ",";
                }
            }
            if (UsertypeB)
            {
                //first add the parameter for Password
                query += " Usertype = \'" + Usertype + "\'";

                //now if there is another param coming, we need to add a comma
                if (EmailB)
                {
                    query += ",";
                }
            }
            if (EmailB)
            {
                //first add the parameter for Password
                query += " Email = \'" + Email + "\'";

                //there will never be a comma after Email
            }

            #endregion buildString

            //now add the where statement so that we target the right ticket
            query += " WHERE Username = \'" + Username + "\';";

            //now build the SQL command and execute it
            SqlCommand cmd = new SqlCommand(query, connection_);

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddAssignment(int TicketNum, string Username)
        {
            //make sure that the ticket and user actually exist
            if (!IsDuplicateInt("Ticket", "TicketNum", TicketNum))
            {
                //MessageBox.Show("Fail!");
                return false;
            }

            //don't use IsDuplicate bc we want the additional condition that the user is IT
            string readUserQueryString = "SELECT * FROM U_ser WHERE Username = \'" + Username + "\' AND UserType = \'I\';";
            SqlCommand readUserCmd = new SqlCommand(readUserQueryString, connection_);
            reader_ = readUserCmd.ExecuteReader();
            if (!reader_.HasRows)
            {
                reader_.Close();
                return false;
            }
            reader_.Close();

            //we know that the given ticket and user actually exists

            //make sure that this assignment doesn't already exist
            string readQueryString = "SELECT * FROM Assignment WHERE Username = \'" + Username + "\' AND TicketNum = " + TicketNum + ";";
            SqlCommand readCmd = new SqlCommand(readQueryString, connection_);
            reader_ = readCmd.ExecuteReader();

            if (reader_.HasRows)
            {
                reader_.Close();
                return false;
            }
            reader_.Close();

            //now we know that TicketNum and Username both exists AND that they would form a unique assignment together

            string insertQueryString1 = "INSERT INTO Assignment (TicketNum,Username) VALUES (" + TicketNum + ",\'" + Username + "\'" + ")";
            SqlCommand insertCmd = new SqlCommand(insertQueryString1, connection_);
            insertCmd.ExecuteNonQuery();

            //now reflect this ticket in the numTicketsAssigned column. Do not increment if adding a member to a closed ticket
            reader_ = Read("SELECT Status FROM Ticket WHERE TicketNum = " + TicketNum);
            reader_.Read();
            string status = reader_.GetString(0).Substring(0, 1);
            reader_.Close();
            if (status.Equals("O"))
            {
                SqlCommand incrementCmd = new SqlCommand("UPDATE U_ser SET NumTicketsAssigned = NumTicketsAssigned + 1 WHERE Username = \'" + Username + "\';", connection_);
                incrementCmd.ExecuteNonQuery();
            }

            return true;
        }

        public bool DropAssignment(int TicketNum, string Username)
        {
            //There is nothing to check because if the row doesn't exist, ExecuteNonQuery() will
            //simply return 0;

            string queryString = "DELETE FROM Assignment WHERE TicketNum = " + TicketNum + " AND Username = \'" + Username + "\';";
            SqlCommand cmd = new SqlCommand(queryString, connection_);

            //decrement the number of assigned tickets for the user
            try
            {
                SqlCommand decrementCmd = new SqlCommand("UPDATE U_ser SET NumTicketsAssigned = NumTicketsAssigned - 1 WHERE Username = \'" + Username + "\';", connection_);
                decrementCmd.ExecuteNonQuery();
            } 
            catch (Exception ex)
            {
                SqlCommand decrementCmd = new SqlCommand("UPDATE U_ser SET NumTicketsAssigned = 0 WHERE Username = \'" + Username + "\';", connection_);
                decrementCmd.ExecuteNonQuery();
            }

            if (cmd.ExecuteNonQuery() == 1)
            {
                return true;
            }

            return false;
        }

        //Returns the Usertype when column == 0, returns Email whe column == 1
        public string initializeUser(string User, int column)
        {
            string queryString = "";

            if (column == 0)
            {
                queryString = "SELECT Usertype FROM U_ser WHERE Username = \'" + User + "\';";
            }
            else if (column == 1)
            {
                queryString = "SELECT Email FROM U_ser WHERE Username = \'" + User + "\';";
            }
            else if (column == 2)
            {
                queryString = "SELECT Password FROM U_ser WHERE Username = \'" + User + "\';";
            }

            SqlCommand command = new SqlCommand(queryString, connection_);

            reader_ = command.ExecuteReader();

            reader_.Read();

            string returnString = reader_.GetString(0);

            reader_.Close();

            return returnString;
        }

        private SqlDataReader Read(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection_);
            reader_ = cmd.ExecuteReader();
            return reader_;
        }

        //given a reader, a column, and a string to compare to that column. Returns true when the string appears in the given column
        public bool IsDuplicateString(string TableName, string ColumnName, string Candidate)
        {
            string queryString = "SELECT " + ColumnName + " FROM " + TableName + " WHERE " + ColumnName + " = \'" + Candidate + "\';";
            SqlCommand cmd = new SqlCommand(queryString, connection_);
            SqlDataReader subReader = cmd.ExecuteReader();

            //if a record in the given table already exists with the given key, return true
            if (subReader.HasRows)
            {
                subReader.Close();
                return true;
            }
            subReader.Close();
            return false;
        }

        private bool IsDuplicateInt(string TableName, string ColumnName, int Candidate)
        {
            string queryString = "SELECT " + ColumnName + " FROM " + TableName + " WHERE " + ColumnName + " = " + Candidate + ";";
            SqlCommand cmd = new SqlCommand(queryString, connection_);
            SqlDataReader subReader = cmd.ExecuteReader();

            //if a record in the given table already exists with the given key, return true
            if (subReader.HasRows)
            {
                subReader.Close();
                return true;
            }
            subReader.Close();
            return false;
        }

        private string pickAssignment()
        {
            Dictionary<int, string> map = new Dictionary<int, string>();

            //loop through the IT users and add their ticket total to the map
            string queryString = "SELECT Username, NumTicketsAssigned FROM U_ser WHERE Usertype = \'I\' ORDER BY NumTicketsAssigned ASC;";
            SqlCommand cmd = new SqlCommand(queryString, connection_);
            SqlDataReader subReader = cmd.ExecuteReader();

            //now the IT member with the least tickets is at the top of the reader
            subReader.Read();
            string returnUser = subReader.GetString(0);
            subReader.Close();
            return returnUser;
        }

        private void unAssignTicket(int tickID)
        {
            //decrements the numTicksAssigned columns for all relavent users
            SqlDataReader subReader = Read("SELECT Username FROM Assignment WHERE TicketNum = " + tickID);
            List<string> users = new List<string>();

            while (subReader.Read())
            {
                users.Add(subReader.GetString(0));
            }
            subReader.Close();

            //now loop through the list and decrement numTicks for each user
            for(int i = 0; i < users.Capacity; i++)
            {
                string queryString = "UPDATE U_ser SET NumTicketsAssigned = NumTicketsAssigned - 1 WHERE Username = \'" + users[i].Trim() + "\';";
                SqlCommand decrementCmd = new SqlCommand(queryString, connection_);
                decrementCmd.ExecuteNonQuery();
            }
        }
        private void reAssignTicket(int tickID)
        {
            //increments the numTicksAssigned columns for all relavent users
            SqlDataReader subReader = Read("SELECT Username FROM Assignment WHERE TicketNum = " + tickID);
            List<string> users = new List<string>();

            while (subReader.Read())
            {
                users.Add(subReader.GetString(0));
            }
            subReader.Close();

            //now loop through the list and increment numTicks for each user
            foreach (string current in users)
            {
                SqlCommand decrementCmd = new SqlCommand("UPDATE U_ser SET NumTicketsAssigned = NumTicketsAssigned + 1 WHERE Username = \'" + current + "\';", connection_);
                decrementCmd.ExecuteNonQuery();
            }
        }
        public List<string> forgotPassword(string Username)
        {
            reader_ = Read("SELECT Email, Password FROM U_ser WHERE Username = \'" + Username + "\';");

            List<string> items = new List<string>();

            if (reader_.Read())
            {
                items.Add(reader_.GetString(0));
                items.Add(reader_.GetString(1));

            }
            else
            {
                items.Add("");
                items.Add("");
            }
            reader_.Close();

            return items;
        }
        public string forgotUsername(string email)
        {
            reader_ = Read("SELECT Username FROM U_ser WHERE Email = \'" + email.Trim() + "\'");

            string username = "";

            if (reader_.Read())
            {
                username = reader_.GetString(0);
            }
            reader_.Close();

            return username;
        }
        public List<string> getTicketsAssignedToUserAsString(string username, bool getClosed)
        {
            List<string> info = new List<string>();
            //string queryString = "SELECT TicketNum, Subject, Status, Priority FROM dbo.Ticket WHERE UserCreated = '" + username + "';";
            string queryString;
            if(getClosed)
            { 
                queryString = "SELECT T.TicketNum, T.Status, T.Priority, T.Subject, T.Description, A.Username AS AssignedTo FROM[dbo].[U_ser] U JOIN[dbo].[Ticket] T ON U.Username = T.UserCreated LEFT JOIN[dbo].[Assignment] A ON T.TicketNum = A.TicketNum WHERE U.Username = '" + username + "';"; 
            }
            else
            {
                queryString = "SELECT T.TicketNum, T.Status, T.Priority, T.Subject, T.Description, A.Username AS AssignedTo FROM[dbo].[U_ser] U JOIN[dbo].[Ticket] T ON U.Username = T.UserCreated LEFT JOIN[dbo].[Assignment] A ON T.TicketNum = A.TicketNum WHERE U.Username = '" + username + "' AND T.Status = 'O';";
            }
            
            SqlCommand command = new SqlCommand(queryString, connection_);
            using (command)
            {
                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string rowFormat = "{0} {1} {2} {3}\n";

                    while (reader.Read())
                    {
                        StringBuilder result = new StringBuilder();
                        string ticketNum = reader["TicketNum"].ToString();
                        string subject = reader["Subject"].ToString();
                        string status = reader["Status"].ToString();
                        string priority = reader["Priority"].ToString();
                        switch (status)
                        {
                            case "O":
                                status = "(Opened,";
                                break;
                            case "C":
                                status = "(Closed,";
                                break;
                            default:
                                status = "(Unknown,";
                                break;
                        }

                        switch (priority)
                        {
                            case "H":
                                priority = "High)";
                                break;
                            case "M":
                                priority = "Medium)";
                                break;
                            case "U":
                                priority = "Urgent)";
                                break;
                            case "L":
                                priority = "Low)";
                                break;
                            default:
                                priority = "Unknown)";
                                break;
                        }
                        if (string.IsNullOrWhiteSpace(subject))
                        {
                            subject = "*EMPTY SUBJECT*";
                        }
                        //result.AppendFormat(rowFormat, ticketNum, subject, status, priority);
                        result.AppendFormat(rowFormat, ticketNum, subject, status, priority);
                        info.Add(result.ToString());
                    }
                }
            }
            return info;
        }
        public List<string> getAllTickets(bool getClosed)
        {
            List<string> info = new List<string>();
            //string queryString = "SELECT TicketNum, Subject, Status, Priority FROM dbo.Ticket;";
            //Maybe modify to get all it members working on it
            string queryString;
            if (getClosed)
            {
                queryString = "SELECT DISTINCT T.TicketNum, T.Subject, T.Status, T.Priority FROM[dbo].[U_ser] U JOIN[dbo].[Ticket] T ON U.Username = T.UserCreated LEFT JOIN[dbo].[Assignment] A ON T.TicketNum = A.TicketNum;";
            }
            else
            {
                queryString = "SELECT DISTINCT T.TicketNum, T.Subject, T.Status, T.Priority FROM[dbo].[U_ser] U JOIN[dbo].[Ticket] T ON U.Username = T.UserCreated LEFT JOIN[dbo].[Assignment] A ON T.TicketNum = A.TicketNum WHERE T.Status = 'O';";
            }
            SqlCommand command = new SqlCommand(queryString, connection_);
            using (command)
            {

                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string rowFormat = "{0} {1} {2} {3}\n";

                    while (reader.Read())
                    {
                        StringBuilder result = new StringBuilder();
                        string ticketNum = reader["TicketNum"].ToString();
                        string subject = reader["Subject"].ToString();
                        string status = reader["Status"].ToString();
                        string priority = reader["Priority"].ToString();
                        switch (status)
                        {
                            case "O":
                                status = "(Opened,";
                                break;
                            case "C":
                                status = "(Closed,";
                                break;
                            default:
                                status = "(Unknown,";
                                break;
                        }

                        switch (priority)
                        {
                            case "H":
                                priority = "High)";
                                break;
                            case "M":
                                priority = "Medium)";
                                break;
                            case "U":
                                priority = "Urgent)";
                                break;
                            case "L":
                                priority = "Low)";
                                break;
                            default:
                                priority = "Unknown)";
                                break;
                        }
                        if (string.IsNullOrWhiteSpace(subject))
                        {
                            subject = "*EMPTY SUBJECT*";
                        }
                        //result.AppendFormat(rowFormat, ticketNum, subject, status, priority);
                        result.AppendFormat(rowFormat, ticketNum, subject, status, priority);
                        info.Add(result.ToString());
                    }
                }
            }
            return info;
        }
        public string AllInfo(int tickVal)
        {
            StringBuilder info = new StringBuilder();
            //string queryString = "SELECT Status, TicketNum,UserCreated, UserAssignedTo, Priority, Subject, Description FROM dbo.Ticket WHERE TicketNum = @TicketId";
            //Maybe modify to get all users
            string queryString = "SELECT t.Status, t.TicketNum, t.UserCreated, a.Username AS UserAssignedTo, t.Priority, t.Subject, t.Description FROM dbo.Ticket t INNER JOIN dbo.Assignment a ON t.TicketNum = a.TicketNum WHERE t.TicketNum = @TicketId;";
            //connectionString_ = "Server=tcp:se361server.database.windows.net,1433;Initial Catalog=ITHelpDesk;Persist Security Info=False;User ID=guguladmin;Password=se3612023-gugul;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //connection_ = new SqlConnection(connectionString_);
            //connection_.Open();
            //Grab an sql data reader and put a vector in the vector
            SqlCommand command = new SqlCommand(queryString, connection_);
            using (command)
            {

                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }
                int ticketIdInt = Convert.ToInt32(tickVal);
                command.Parameters.AddWithValue("@TicketId", ticketIdInt);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string rowFormat = " Ticket Status: {0}\n Ticker Number: {1}\n User Created: {2}\n IT Helper: {3}\n Priority Level: {4}\n Subject: {5}\n Description: {6}\n";

                    while (reader.Read())
                    {
                        StringBuilder result = new StringBuilder();
                        string status = reader["Status"].ToString();
                        string ticketNum = reader["TicketNum"].ToString();
                        string userCreated = reader["UserCreated"].ToString();
                        string userAssignedTo = reader["UserAssignedTo"].ToString();
                        string priority = reader["Priority"].ToString();
                        string subject = reader["Subject"].ToString();
                        string description = reader["Description"].ToString();
                        switch (status)
                        {
                            case "O":
                                status = "Opened";
                                break;
                            case "C":
                                status = "Closed";
                                break;
                            default:
                                status = "Unknown";
                                break;
                        }

                        switch (priority)
                        {
                            case "H":
                                priority = "High";
                                break;
                            case "M":
                                priority = "Medium";
                                break;
                            case "U":
                                priority = "Urgent";
                                break;
                            case "L":
                                priority = "Low";
                                break;
                            default:
                                priority = "Unknown";
                                break;
                        }
                        if (string.IsNullOrWhiteSpace(subject))
                        {
                            subject = "*EMPTY SUBJECT*";
                        }
                        info.AppendFormat(rowFormat, status, ticketNum, userCreated, userAssignedTo, priority, subject, description);
                        //info.Add(result.ToString());
                    }
                }
            }
            return info.ToString();
        }
        public List<string> vectorAllInfo(int tickVal)
        {

            List<string> myinfo = new List<string>();
            StringBuilder info = new StringBuilder();
            //Maybe modify to get all users
            string queryString = "SELECT t.Status, t.TicketNum, t.UserCreated, a.Username AS UserAssignedTo, t.Priority, t.Subject, t.Description, t.TicketResponse FROM dbo.Ticket t INNER JOIN dbo.Assignment a ON t.TicketNum = a.TicketNum WHERE t.TicketNum = @TicketId;";
            connectionString_ = "Server=tcp:se361server.database.windows.net,1433;Initial Catalog=ITHelpDesk;Persist Security Info=False;User ID=guguladmin;Password=se3612023-gugul;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection_ = new SqlConnection(connectionString_);
            connection_.Open();
            //Grab an sql data reader and put a vector in the vector
            SqlCommand command = new SqlCommand(queryString, connection_);
            using (command)
            {

                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }
                int ticketIdInt = Convert.ToInt32(tickVal);
                command.Parameters.AddWithValue("@TicketId", ticketIdInt);
                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        StringBuilder result = new StringBuilder();
                        string status = reader["Status"].ToString();
                        string ticketNum = reader["TicketNum"].ToString();
                        string userCreated = reader["UserCreated"].ToString();
                        string userAssignedTo = reader["UserAssignedTo"].ToString();
                        string priority = reader["Priority"].ToString();
                        string subject = reader["Subject"].ToString();
                        string description = reader["Description"].ToString();
                        string response = reader["TicketResponse"].ToString();

                        switch (status)
                        {
                            case "O":
                                status = "Opened";
                                break;
                            case "C":
                                status = "Closed";
                                break;
                            default:
                                status = "Unknown";
                                break;
                        }

                        switch (priority)
                        {
                            case "H":
                                priority = "High";
                                break;
                            case "M":
                                priority = "Medium";
                                break;
                            case "U":
                                priority = "Urgent";
                                break;
                            case "L":
                                priority = "Low";
                                break;
                            default:
                                priority = "Unknown";
                                break;
                        }
                        //info.AppendFormat(rowFormat, status, ticketNum, userCreated, userAssignedTo, priority, subject, description);
                        //info.Add(result.ToString());
                        //Traditional Adding to a list
                        //result.AppendFormat(rowFormat, status, ticketNum, userCreated, userAssignedTo, priority, subject, description);
                        //myinfo.Add(result.ToString());
                        myinfo.Add("Status: " + status.ToString());
                        myinfo.Add("Ticket Number: " + ticketNum.ToString());
                        myinfo.Add("Created By: " + userCreated.ToString());
                        myinfo.Add("Helper: " + userAssignedTo.ToString());
                        myinfo.Add("Priority Status: " + priority.ToString());
                        myinfo.Add("Subject: " + subject.ToString());
                        myinfo.Add("Description: " + description.ToString());
                        myinfo.Add("Response: " + response.ToString());

                    }
                }
            }
            return myinfo;
        }
        public List<string> getAllITMembers()
        {
            List<string> info = new List<string>();
            string queryString = "SELECT Username FROM dbo.U_ser WHERE UserType = 'I';";
            SqlCommand command = new SqlCommand(queryString, connection_);
            using (command)
            {

                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string rowFormat = "{0}\n";

                    while (reader.Read())
                    {
                        StringBuilder result = new StringBuilder();
                        string username = reader["Username"].ToString();
                        //result.AppendFormat(rowFormat, ticketNum, subject, status, priority);
                        result.AppendFormat(rowFormat, username);
                        info.Add(result.ToString());
                    }
                }
            }
            return info;


        }
        public List<string> getAllTicketsIT(string userName, bool getClosed)
        {
            List<string> info = new List<string>();
            //string queryString = "SELECT TicketNum, Subject, Status, Priority FROM dbo.Ticket;";
            //Maybe modify to get all it members working on it
            string queryString;
            if (getClosed)
            {
                queryString = "SELECT T.TicketNum, T.Subject, T.Status, T.Priority FROM [dbo].[U_ser] U JOIN [dbo].[Ticket] T ON U.Username = T.UserCreated LEFT JOIN [dbo].[Assignment] A ON T.TicketNum = A.TicketNum WHERE A.Username = '" + userName + "'";
            }
            else
            {
                queryString = "SELECT T.TicketNum, T.Subject, T.Status, T.Priority FROM [dbo].[U_ser] U JOIN [dbo].[Ticket] T ON U.Username = T.UserCreated LEFT JOIN [dbo].[Assignment] A ON T.TicketNum = A.TicketNum WHERE A.Username = '" + userName + "' AND T.Status = 'O'";
            }
            SqlCommand command = new SqlCommand(queryString, connection_);
            using (command)
            {
                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string rowFormat = "{0} {1} {2} {3}\n";

                    while (reader.Read())
                    {
                        StringBuilder result = new StringBuilder();
                        string ticketNum = reader["TicketNum"].ToString();
                        string subject = reader["Subject"].ToString();
                        string status = reader["Status"].ToString();
                        string priority = reader["Priority"].ToString();
                        switch (status)
                        {
                            case "O":
                                status = "(Opened,";
                                break;
                            case "C":
                                status = "(Closed,";
                                break;
                            default:
                                status = "(Unknown,";
                                break;
                        }

                        switch (priority)
                        {
                            case "H":
                                priority = "High)";
                                break;
                            case "M":
                                priority = "Medium)";
                                break;
                            case "U":
                                priority = "Urgent)";
                                break;
                            case "L":
                                priority = "Low)";
                                break;
                            default:
                                priority = "Unknown)";
                                break;
                        }
                        if (string.IsNullOrWhiteSpace(subject))
                        {
                            subject = "*EMPTY SUBJECT*";
                        }
                        //result.AppendFormat(rowFormat, ticketNum, subject, status, priority);
                        result.AppendFormat(rowFormat, ticketNum, subject, status, priority);
                        info.Add(result.ToString());
                    }
                }
            }
            return info;
        }
        public string getSubject(int ID)
        {
            string subject = "";
            string queryString = "SELECT Subject FROM [dbo].[Ticket] WHERE TicketNum = '" + ID + "';";
            connectionString_ = "Server=tcp:se361server.database.windows.net,1433;Initial Catalog=ITHelpDesk;Persist Security Info=False;User ID=guguladmin;Password=se3612023-gugul;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection_ = new SqlConnection(connectionString_);
            connection_.Open();
            SqlCommand command = new SqlCommand(queryString, connection_);
            using (command)
            {
                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string rowFormat = "{0}\n";

                    while (reader.Read())
                    {
                        subject = reader["Subject"].ToString();

                        if (string.IsNullOrWhiteSpace(subject))
                        {
                            subject = "*EMPTY SUBJECT*";
                        }
                    }
                }
            }
            return subject;
        }
        public void ReOpen(int ID)
        {
            //MessageBox.Show(ticketID.ToString());
            //MessageBox.Show(ticketResponse.ToString());
            //connectionString_ = "Server=tcp:se361server.database.windows.net,1433;Initial Catalog=ITHelpDesk;Persist Security Info=False;User ID=guguladmin;Password=se3612023-gugul;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection_ = new SqlConnection(connectionString_);
            connection_.Open();
            using (connection_)
            {
                try
                {
                    string updateQuery = "UPDATE dbo.Ticket SET Status = 'O' WHERE TicketNum = '" + ID + "';";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection_))
                    {

                        int rowsAffected = command.ExecuteNonQuery();
                        //MessageBox.Show("Rows affected: " + rowsAffected);
                    }

                    //now increment the numTicksAssigned for all users assigned
                    reAssignTicket(ID);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        public void UpdateTicketResponseAndStatus(int ticketID, string ticketResponse)
        {
            //MessageBox.Show(ticketID.ToString());
            //MessageBox.Show(ticketResponse.ToString());
            using (connection_)
            {
                try
                {
                    string updateQuery = "UPDATE dbo.Ticket SET TicketResponse = @ticketResponse, Status = 'C' WHERE TicketNum = @ticketID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection_))
                    {
                        command.Parameters.AddWithValue("@ticketResponse", ticketResponse);
                        command.Parameters.AddWithValue("@ticketID", ticketID);

                        int rowsAffected = command.ExecuteNonQuery();
                        //MessageBox.Show("Rows affected: " + rowsAffected);
                    }

                    //since the ticket is being closed, we don't want this ticket reflected on the users its assigned to
                    unAssignTicket(ticketID);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        public string getEmail(int ID)
        {
            StringBuilder result = new StringBuilder();
            //string queryString = "SELECT TicketNum, Subject, Status, Priority FROM dbo.Ticket WHERE UserCreated = '" + username + "';";
            string queryString = "SELECT UserCreated FROM dbo.Ticket WHERE TicketNum =  '" + ID + "';";

            string userCreated = " ";
            string rowFormat = "{0}\n";

            string user = " ";
            SqlCommand command = new SqlCommand(queryString, connection_);
            using (command)
            {
                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userCreated = reader["UserCreated"].ToString();
                        //result.AppendFormat(rowFormat,userCreated);
                        //user = result.ToString();
                    }
                }
            }
            string queryString2 = "SELECT Email FROM dbo.U_ser WHERE Username =  '" + userCreated + "';";
            StringBuilder result2 = new StringBuilder();
            string ans = " ";
            string Email = "";
            SqlCommand command2 = new SqlCommand(queryString2, connection_);
            using (command2)
            {
                if (connection_.State != ConnectionState.Open)
                {
                    connection_.Open();
                }

                using (SqlDataReader reader2 = command2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        Email = reader2["Email"].ToString();
                        result2.AppendFormat(rowFormat, Email);
                        ans = result2.ToString();
                    }
                }
            }
            //MessageBox.Show(ans);
            return Email;
        }
    }
}
