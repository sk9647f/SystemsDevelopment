using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

public class Play

{
    int playID;
    string oldTitle;
    string title;
    string genre;
    string description; // include duration of play
    string date;
    string time;
    //have to use datetime function to switch from a string into a formatted datetime
    string ticketsAvailable;
    string ticketsQuantity;

    // Might not need any full class variables if arguments are given in by the main. As this class doesn't create any objects with these varialbes, only pushes them between the code and database.



    //Unsure on what functionality can be implemented without a linked database being created before hand



    public void AddPlay(string addTitle, string addGenre, string addDescription, string addDateOfPlay, string addTimeOfPlay, string addTicketsAvailable, string addTicketsQuantity)
    {
        title = addTitle;
        genre = addGenre;
        description = addDescription;
        date = addDateOfPlay;
        time = addTimeOfPlay;
        ticketsAvailable = addTicketsAvailable;
        ticketsQuantity = addTicketsQuantity;



        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();
        OleDbCommand myCommand = new OleDbCommand("INSERT INTO Plays (PlayID, Title, Genre, Description, DateOfPlay, TimeOfPlay, TicketsAvailable, TicketsQuantity) VALUES (?,?,?,?,?,?,?,?)", myConnection);

        myCommand.Parameters.AddWithValue("@PlayID", playID);
        myCommand.Parameters.AddWithValue("@Title", title);
        myCommand.Parameters.AddWithValue("@Genre", genre);
        myCommand.Parameters.AddWithValue("@Description", description);
        myCommand.Parameters.AddWithValue("@DateOfPlay", date);
        myCommand.Parameters.AddWithValue("@TimeOfPlay", time);
        myCommand.Parameters.AddWithValue("@TicketsAvailable", ticketsAvailable);
        myCommand.Parameters.AddWithValue("@TicketsQuantity", ticketsQuantity);

        myCommand.ExecuteNonQuery();
        myConnection.Close();


    }

    public void EditTitle(string editTitle, string Oldtitle, int PlayID)
    {
        title = editTitle;
        playID = PlayID;
        oldTitle = OldRitle;
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();
        OleDbCommand myCommand = new OleDbCommand("UPDATE Plays, SET /*@Inputstring*/  Title = @Title, WHERE Title = @OldTitle && PlayID = @playID, myConnection);

        myCommand.Parameters.AddWithValue("@PlayID", playID);
        myCommand.Parameters.AddWithValue("@Title", title);
        

        myCommand.ExecuteNonQuery();
        myConnection.Close();
    }
                                                  
    

    public void DeletePlay(string deleteTitle, string deleteDate)
    {
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();

        OleDbCommand myCommand = new OleDbCommand("DELETE FROM Plays WHERE Title = TitleDelete ", myConnection);
        myCommand.Parameters.AddWithValue("@TitleDelete", deleteTitle);

        myCommand.ExecuteNonQuery();
        myConnection.Close();

        //May need more identifiers to prevent clashes
    }

    public string DisplayReview(string readTitle, string readDate)
    {
        string returnReview = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";


        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();


        OleDbCommand myCommand = new OleDbCommand("SELECT Reviews FROM Plays WHERE Title = @Title", myConnection);
        myCommand.Parameters.AddWithValue("@Title", readTitle);



        OleDbDataReader reader = myCommand.ExecuteReader();
        while (reader.Read())
        {
            returnReview = reader.GetString(0);

        }
        reader.Close();
        return returnReview;


    }


    //Using both the title and its date as an identifier 

}
