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
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();



            OleDbCommand myCommand = new OleDbCommand("INSERT INTO Reviews (Author, Review, Title) VALUES (?, ?, ?)", myConnection);
            myCommand.Parameters.AddWithValue("@Author", UserID);
            myCommand.Parameters.AddWithValue("@Review", Review);
            myCommand.Parameters.AddWithValue("@Title", Title);


            myCommand.ExecuteNonQuery();
        }
        public void DeleteReview()
        {

        }

    }
}
