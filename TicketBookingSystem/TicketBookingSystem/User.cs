using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TicketBookingSystem
{
    abstract class User
    {

        public int ID;
        public string userName;
        public string password;
        public string forName;
        public string surName;
        public string address;
        public string phoneNumber;
        public string email;
        public bool staff;
        public string loginUsername;
        public string loginPassword;
        public string details;




        
        public abstract void AddUser(string user, string pass, string forname, string surname, string address, string phoneNumber, string email);
        public abstract void DeleteUser(string user);
        public abstract void DisplayProfile(string user);
        public abstract void EditPersonalDetails(string user);
        public abstract void UpdateDetails(string user, string pass, string forname, string surname, string address, string phoneNumber, string email, string loginUsername);

    }



    class Customer : User
    {
     


        public override void AddUser(string user, string pass, string forname, string surname, string address, string phoneNumber, string email)
        {

          


            //needs to write to database 
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);

            OleDbCommand myCommand = new OleDbCommand("INSERT INTO [User] (Forename, Surname, Username, [Password], PhoneNumber, Address, Email) VALUES (?, ?, ?, ?, ?, ?, ?)", myConnection);

            myCommand.Parameters.AddWithValue("@Forname", forname);
            myCommand.Parameters.AddWithValue("@Surname", surname);
            myCommand.Parameters.AddWithValue("@Username", user);
            myCommand.Parameters.AddWithValue("@Password", pass);
            myCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            myCommand.Parameters.AddWithValue("@Address", address);
            myCommand.Parameters.AddWithValue("@Email", email);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        public override void DeleteUser(string user)
        {
            //delete row from database
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand("DELETE FROM [User] WHERE Username = @Username", myConnection);
            myCommand.Parameters.AddWithValue("@Username", user);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public override void DisplayProfile(string user)
        {
            //show details from database or local variables
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();


            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [User] WHERE Username = @Username", myConnection);
            myCommand.Parameters.AddWithValue("@Username", user);
            OleDbDataReader reader = myCommand.ExecuteReader();


            while (reader.Read())
            {

                for (int i = 1; i < 8; i++)
                {

                    details += reader.GetString(i) + " " + "\n" + "\n" + "\n";

                }

            }


            myConnection.Close();

        }




        public void ViewOrderHistory()
        {

        }


        public override void EditPersonalDetails(string user)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [User] WHERE Username = @Username", myConnection);
            myCommand.Parameters.AddWithValue("@Username", user);
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                userName = reader.GetString(3);
                password = reader.GetString(4);
                forName = reader.GetString(1);
                surName = reader.GetString(2);
                address = reader.GetString(6);
                phoneNumber = reader.GetString(5);
                email = reader.GetString(7);
            }
        }

        public override void UpdateDetails(string user, string pass, string forname, string surname, string address, string phoneNumber, string email, string loginUsername)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);

            OleDbCommand myCommand = new OleDbCommand("UPDATE [User] SET Forename = @Forname, Surname = @Surname, Username = @Username, [Password] = @Password, PhoneNumber = @PhoneNumber, Address = @Address, Email = @Email WHERE Username = @LoginUsername", myConnection);

            myCommand.Parameters.AddWithValue("@Forname", forname);
            myCommand.Parameters.AddWithValue("@Surname", surname);
            myCommand.Parameters.AddWithValue("@Username", user);
            myCommand.Parameters.AddWithValue("@Password", pass);
            myCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            myCommand.Parameters.AddWithValue("@Address", address);
            myCommand.Parameters.AddWithValue("@Email", email);
            myCommand.Parameters.AddWithValue("@LoginUsername", loginUsername);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

    }

    class Staff : User
    {
        //int staffID;



        public override void AddUser(string user, string pass, string forname, string surname, string address, string phoneNumber, string email)
        {
            //id = staffID;
        }

        public override void DeleteUser(string user)
        {

        }

        public override void DisplayProfile(string user)
        {

        }


        public void DeleteReviews()
        {

        }

        public void AddPlay()
        {

        }

        public void EditPlay()
        {

        }

        public void DeletePlay()
        {

        }

        public override void EditPersonalDetails(string user)
        {

        }

        public override void UpdateDetails(string user, string pass, string forname, string surname, string address, string phoneNumber, string email, string loginUsername)
        {

        }


    }
}
