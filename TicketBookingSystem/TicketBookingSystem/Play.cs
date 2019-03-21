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



    public void AddPlay(string addTitle, string addGenre, string addDescription, string addDateOfPlay, string addTimeOfPlay, string addTicketsAvailable, string addTicketsQuantity)
    {
        //playID = 1;
        title = addTitle;
        genre = addGenre;
        description = addDescription;
        date = addDateOfPlay;
        time = addTimeOfPlay;
        ticketsAvailable = addTicketsAvailable;
        ticketsQuantity = addTicketsQuantity;



        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();
        OleDbCommand myCommand = new OleDbCommand("INSERT INTO Plays (Title, Genre, Description, DateOfPlay, TimeOfPlay, TicketsAvailable, TicketsQuantity) VALUES (?,?,?,?,?,?,?)", myConnection);

        //myCommand.Parameters.AddWithValue("@PlayID", playID);
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

    public void EditPlayFields(string Input, string Edit, string PlayID)
    {
        string InputField = Input;
        string EditField = Edit;
        string PlayIDField = PlayID;
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();





        if (InputField == "Title")
        {
            OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET Title = @Change WHERE PlayID = @PlayID", myConnection);
            myCommand.Parameters.AddWithValue("@Change", EditField);
            myCommand.Parameters.AddWithValue("@PlayID", PlayIDField);
            myCommand.ExecuteNonQuery();
        }
        if (InputField == "Description")
        {
            OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET Description = @Change WHERE PlayID = @PlayID", myConnection);
            myCommand.Parameters.AddWithValue("@Change", EditField);
            myCommand.Parameters.AddWithValue("@PlayID", PlayIDField);
            myCommand.ExecuteNonQuery();
        }
        if (InputField == "Genre")
        {
            OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET Genre = @Change WHERE PlayID = @PlayID", myConnection);
            myCommand.Parameters.AddWithValue("@Change", EditField);
            myCommand.Parameters.AddWithValue("@PlayID", PlayIDField);
            myCommand.ExecuteNonQuery();
        }
        if (InputField == "DateOfPlay")
        {
            OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET DateOfPlay = @Change WHERE PlayID = @PlayID", myConnection);
            myCommand.Parameters.AddWithValue("@Change", EditField);
            myCommand.Parameters.AddWithValue("@PlayID", PlayIDField);
            myCommand.ExecuteNonQuery();
        }
        if (InputField == "TimeOfPlay")
        {
            OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET TimeOfPlay = @Change WHERE PlayID = @PlayID", myConnection);
            myCommand.Parameters.AddWithValue("@Change", EditField);
            myCommand.Parameters.AddWithValue("@PlayID", PlayIDField);
            myCommand.ExecuteNonQuery();

        }
        if (InputField == "TicketsAvailable")
        {
            OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET TicketsAvailable = @Change WHERE PlayID = @PlayID", myConnection);
            myCommand.Parameters.AddWithValue("@Change", EditField);
            myCommand.Parameters.AddWithValue("@PlayID", PlayIDField);
            myCommand.ExecuteNonQuery();
        }
        if (InputField == "TicketsQuantity")
        {
            OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET TicketsQuantity = @Change WHERE PlayID = @PlayID", myConnection);
            myCommand.Parameters.AddWithValue("@Change", EditField);
            myCommand.Parameters.AddWithValue("@PlayID", PlayIDField);
            myCommand.ExecuteNonQuery();
        }





        myConnection.Close();
    }

    public void DeletePlay(string title, string playid)
    {

        string TitleDel = title;
        string PlayIDDel = playid;

        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();

        OleDbCommand myCommand = new OleDbCommand("DELETE FROM Plays WHERE Title = @Title  AND PlayID = @PlayID ", myConnection);
        myCommand.Parameters.AddWithValue("@Title", TitleDel);
        myCommand.Parameters.AddWithValue("@PlayID", PlayIDDel);

        myCommand.ExecuteNonQuery();
        myConnection.Close();

        //May need more identifiers to prevent clashes
    }

   /* public string DisplayReview(string readTitle, string readDate)
    {
        string input = Genret.Text;
        string returnReview = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();


        OleDbCommand myCommand = new OleDbCommand("SELECT Title FROM Plays WHERE Title = @Title", myConnection);
        myCommand.Parameters.AddWithValue("@Title", input);



        OleDbDataReader reader = myCommand.ExecuteReader();
        while (reader.Read())
        {
            returnReview = reader.GetString(0);

        }
        reader.Close();
        TitleL.Text = returnReview;
        return returnReview;


    }*/

    public string DisplayPlays()
    {

        string returnAllPlays = "";
        string initialreturn = "";
        string addString = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();

        for (int i = 0; i < 500; i++)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE PlayID = @Input", myConnection);
            myCommand.Parameters.AddWithValue("@Input", i);
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

    public void SearchPlays()
    {
        string returnAllPlays = "";
        string initialreturn = "";
        string addString = "";
        string connString;
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
                comboBox1.Items.Add(initialreturn);
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


    }


    //Using both the title and its date as an identifier 

}
