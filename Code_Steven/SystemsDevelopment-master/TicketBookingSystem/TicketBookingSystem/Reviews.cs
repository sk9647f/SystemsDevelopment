using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TicketBookingSystem
{
    class Reviews
    {
        string nameOfCustomer;
        string reviewText;
        DateTime datePosted;
        int rating;

        public void addReview(string UserID, string Review, string Title)
        {
            string checkString;
            float checkValue;
            //needs to write to database 
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();



            OleDbCommand myCommand = new OleDbCommand("INSERT INTO Reviews (Author, Review, Title) VALUES (?, ?, ?)", myConnection);
            myCommand.Parameters.AddWithValue("@Author", UserID);
            myCommand.Parameters.AddWithValue("@Review", Review);
            myCommand.Parameters.AddWithValue("@Title", Title);


            myCommand.ExecuteNonQuery();
        }
        public void DeleteReview(string ReviewID)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);


            OleDbCommand RemoveCommand = new OleDbCommand("DELETE FROM Reviews WHERE ReviewID = @ReviewID", myConnection);
            RemoveCommand.Parameters.AddWithValue("@ReviewID",ReviewID);
            myConnection.Open();
            RemoveCommand.ExecuteNonQuery();
            myConnection.Close();
        }


        public string DisplayReview(string Title)
        {

            string returnReview = "";
            int returnint;
            string addString = "";
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();


            OleDbCommand myCommand = new OleDbCommand("SELECT DISTINCT ReviewID, Author, Review FROM Reviews WHERE Title = @Title", myConnection);
            myCommand.Parameters.AddWithValue("@Title", Title);



            OleDbDataReader reader = myCommand.ExecuteReader();

            if(Account.LoginUsername == "Staff1")
            {
                while (reader.Read())
                {

                    returnint = reader.GetInt32(0);
                    addString += "ReviewID = " + returnint;
                    returnReview = reader.GetString(1);
                    addString += "   Author: " + returnReview + ": ";
                    returnReview = reader.GetString(2);
                    addString += "  " + returnReview + "";
                    addString += "\n";
                    addString += "\n";

                }
            }

            else
            {
                while (reader.Read())
                {

                   
                    returnReview = reader.GetString(1);
                    addString += "   Author: " + returnReview + ": ";
                    returnReview = reader.GetString(2);
                    addString += "  " + returnReview + "";
                    addString += "\n";
                    addString += "\n";

                }
            }
            
            reader.Close();

            return addString;


        }

    }
}
