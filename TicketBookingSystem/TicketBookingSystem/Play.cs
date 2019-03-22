using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

public class Play

{
    int playID;
    public string title;
    string genre;
    string description; // include duration of play
    string date;
    public string time;
    //have to use datetime function to switch from a string into a formatted datetime
    string ticketsAvailable;
    string ticketsQuantity;
    public List <string> comboValue = new List<string>();
    //string[] array;


    // Might not need any full class variables if arguments are given in by the main. As this class doesn't create any objects with these varialbes, only pushes them between the code and database.



    //Unsure on what functionality can be implemented without a linked database being created before hand




    public string DisplayReview()
    {

        string returnReview = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();


        OleDbCommand myCommand = new OleDbCommand("SELECT DISTINCT Title FROM Plays WHERE Title = @Title", myConnection);
        //myCommand.Parameters.AddWithValue("@Title", input);



        OleDbDataReader reader = myCommand.ExecuteReader();
        while (reader.Read())
        {
            returnReview = reader.GetString(0);

        }
        reader.Close();

        return returnReview;


    }

    public string DisplayPlays()
    {

        string returnAllPlays = "";
        string initialreturn = "";
        string addString = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();


        OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays", myConnection);

        OleDbDataReader reader = myCommand.ExecuteReader();
        while (reader.Read())
        {
            initialreturn = reader.GetString(0);

            addString += "Title: " + initialreturn + "  ";
            initialreturn = reader.GetDateTime(1).ToShortDateString();
            addString += "Date: " + initialreturn + "  ";
            initialreturn = reader.GetDateTime(2).ToShortTimeString();
            addString += "Time: " + initialreturn + "\n";
            addString += "\n";
            addString += "\n";


        }


        myConnection.Close();

        returnAllPlays = addString;

        //AllPlaysl.Text = returnAllPlays;
        return returnAllPlays;

    }

    public void SearchPlays(string titleInput, DateTime dateInput)
    {

        string connString;

        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();


        OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE Title = @InputTitle AND DateofPlay = @InputDate", myConnection);
        myCommand.Parameters.AddWithValue("@InputTitle", titleInput);
        myCommand.Parameters.AddWithValue("@InputDate", dateInput);
        OleDbDataReader reader = myCommand.ExecuteReader();
        while (reader.Read())
        {



            title = reader.GetString(0);
            time = reader.GetDateTime(2).ToShortTimeString();


            
            comboValue.Add(title + "" + time);




        }


        myConnection.Close();


    }


    //Using both the title and its date as an identifier 

}
