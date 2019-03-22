using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

public class Play

{
    int playID;
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

        for (int i = 0; i < 50; i++)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays", myConnection);

            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                initialreturn = reader.GetString(0);

                addString += "Title: " + initialreturn + "  ";
                addString += "\n";
                initialreturn = reader.GetString(1);
                addString += "Date: " + initialreturn + "  ";
                initialreturn = reader.GetString(2);
                addString += "Time: " + initialreturn + "\n";
                addString += "\n";
                addString += "\n";


            }
        }

        myConnection.Close();

        returnAllPlays = addString;

        //AllPlaysl.Text = returnAllPlays;
        return returnAllPlays;

    }

    /*public static SearchPlays()
    {
        string returnAllPlays = "";
        string initialreturn = "";
        string addString = "";
        string connString;
        List<string> forCombo;
        string[] Strings = new string[64];
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();
        for (int i = 0; i < 1; i++)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE DateofPlay = @Input", myConnection);
            myCommand.Parameters.AddWithValue("@Input", dateTimePicker2.Value.ToString("dd/MM/yyyy"));
            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                initialreturn = reader.GetString(0);
                Strings[i] = initialreturn;
                forCombo.Items.Add(initialreturn);
                addString += "Title: " + initialreturn + "  ";
                initialreturn = reader.GetString(1);
                addString += "Date: " + initialreturn + "  ";
                initialreturn = reader.GetString(2);
                addString += "Time: " + initialreturn + "\n";
                addString += "\n";
                addString += "\n";
            }
        }
        myConnection.Close();
        returnAllPlays = addString;
        AllPlaysl.Text = returnAllPlays;
        return Strings;
    }*/


    //Using both the title and its date as an identifier 

}
