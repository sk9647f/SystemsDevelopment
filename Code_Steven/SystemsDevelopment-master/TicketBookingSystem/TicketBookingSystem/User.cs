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
        public string titleE;
        public string genreE;
        public string descriptionE;
        public DateTime dateOfPlayE;
        public DateTime timeOfPlayE;
        public int ticketsAvailableE;
        public int ticketQuantityE;






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
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);

            OleDbCommand myCommand = new OleDbCommand("INSERT INTO [User] (Username, [Password], Forename, Surname, Address, PhoneNumber, Email) VALUES (?, ?, ?, ?, ?, ?, ?)", myConnection);

            myCommand.Parameters.AddWithValue("@Username", user);
            myCommand.Parameters.AddWithValue("@Password", pass);
            myCommand.Parameters.AddWithValue("@Forname", forname);
            myCommand.Parameters.AddWithValue("@Surname", surname);
            myCommand.Parameters.AddWithValue("@Address", address);
            myCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            myCommand.Parameters.AddWithValue("@Email", email);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        public override void DeleteUser(string user)
        {
            //delete row from database
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

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
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
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
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb"; ;
            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [User] WHERE Username = @Username", myConnection);
            myCommand.Parameters.AddWithValue("@Username", user);
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                userName = reader.GetString(1);
                password = reader.GetString(2);
                forName = reader.GetString(3);
                surName = reader.GetString(4);
                address = reader.GetString(5);
                phoneNumber = reader.GetString(6);
                email = reader.GetString(7);
            }
        }

        public override void UpdateDetails(string user, string pass, string forname, string surname, string address, string phoneNumber, string email, string loginUsername)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);

            OleDbCommand myCommand = new OleDbCommand("UPDATE [User] SET Username = @Username, [Password] = @Password, Forename = @Forname, Surname = @Surname, Address = @Address, PhoneNumber = @PhoneNumber, Email = @Email WHERE Username = @LoginUsername", myConnection);

            myCommand.Parameters.AddWithValue("@Username", user);
            myCommand.Parameters.AddWithValue("@Password", pass);
            myCommand.Parameters.AddWithValue("@Forname", forname);
            myCommand.Parameters.AddWithValue("@Surname", surname);
            myCommand.Parameters.AddWithValue("@Address", address);
            myCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
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
            //
        }

        public override void DeleteUser(string user)
        {
            //
        }

        public override void DisplayProfile(string user)
        {
            //
        }


        public void DeleteReviews()
        {

        }

        public void AddPlay(string title, string genre, string description, DateTime dateOfPlay, DateTime timeOfPlay, int ticketsAvailable, int ticketQuantity)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("INSERT INTO Plays (Title, Genre, Description, DateOfPlay, TimeOfPlay, TicketsAvailable, TicketsQuantity) VALUES (?,?,?,?,?,?,?)", myConnection);
       
            myCommand.Parameters.AddWithValue("@Title", title);
            myCommand.Parameters.AddWithValue("@Genre", genre);
            myCommand.Parameters.AddWithValue("@Description", description);
            myCommand.Parameters.AddWithValue("@DateOfPlay", dateOfPlay);
            myCommand.Parameters.AddWithValue("@TimeOfPlay", timeOfPlay);
            myCommand.Parameters.AddWithValue("@TicketsAvailable", ticketsAvailable);
            myCommand.Parameters.AddWithValue("@TicketsQuantity", ticketQuantity);

            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void EditPlay(string title, DateTime dateOfPlay, DateTime timeOfPlay)
        {

            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM Plays WHERE Title = @Title AND DateOfPlay = @DateOfPlay AND TimeOfPlay = @TimeOfPlay", myConnection);
            myCommand.Parameters.AddWithValue("@Title", title);
            myCommand.Parameters.AddWithValue("@DateOfPlay", dateOfPlay);
            myCommand.Parameters.AddWithValue("@TimeOfPlay", timeOfPlay);
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                titleE = reader.GetString(1);
                genreE = reader.GetString(2);
                descriptionE = reader.GetString(3);
                dateOfPlayE = reader.GetDateTime(4);
                timeOfPlayE = reader.GetDateTime(5);
                ticketsAvailableE = reader.GetInt32(6);
                ticketQuantityE = reader.GetInt32(7);
            }


        }


        public void UpdatePlay(string title, string genre, string description, DateTime dateOfPlay, DateTime timeOfPlay, int ticketsAvailable, int ticketQuantity, string titleS, DateTime dateOfPlayS, DateTime timeOfPlayS)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET Title = @Title, Genre = @Genre, Description = @Description, DateOfPlay = @DateOfPlay, TimeOfPlay = @TimeOfPlay, TicketsAvailable = @TicketsAvailable, TicketsQuantity = @TicketsQuantity WHERE Title = @TitleS AND DateOfPlay = @DateOfPlayS AND TimeOfPlay = @TimeOfPlayS", myConnection);

            myCommand.Parameters.AddWithValue("@Title", title);
            myCommand.Parameters.AddWithValue("@Genre", genre);
            myCommand.Parameters.AddWithValue("@Description", description);
            myCommand.Parameters.AddWithValue("@DateOfPlay", dateOfPlay);
            myCommand.Parameters.AddWithValue("@TimeOfPlay", timeOfPlay);
            myCommand.Parameters.AddWithValue("@TicketsAvailable", ticketsAvailable);
            myCommand.Parameters.AddWithValue("@TicketsQuantity", ticketQuantity);
            myCommand.Parameters.AddWithValue("@TitleS", titleS);
            myCommand.Parameters.AddWithValue("@DateOfPlayS", dateOfPlayS);
            myCommand.Parameters.AddWithValue("@TimeOfPlayS", timeOfPlayS);

            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void DeletePlay(string title, DateTime dateOfPlay, DateTime timeOfPlay)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand("DELETE FROM Plays WHERE Title = @Title AND DateOfPlay = @DateOfPlay AND TimeOfPlay = @TimeOfPlay", myConnection);
            myCommand.Parameters.AddWithValue("@Title", title);
            myCommand.Parameters.AddWithValue("@DateOfPlay", dateOfPlay);
            myCommand.Parameters.AddWithValue("@TimeOfPlay", timeOfPlay);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    

        public override void EditPersonalDetails(string user)
        {

        }

        public override void UpdateDetails(string user, string pass, string forname, string surname, string address, string phoneNumber, string email, string loginUsername)
        {

        }


    }
}
