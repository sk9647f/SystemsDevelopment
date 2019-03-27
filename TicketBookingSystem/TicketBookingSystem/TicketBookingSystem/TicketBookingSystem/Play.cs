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
    public int success;
    public float checkValue;
    string genre;
    string description; // include duration of play
    string date;
    string time;
    //have to use datetime function to switch from a string into a formatted datetime
    string ticketsAvailable;
    string ticketsQuantity;
    public List<string> comboValue = new List<string>();
    public List<string> timeBoxValue = new List<string>();
    //string[] array;


    // Might not need any full class variables if arguments are given in by the main. As this class doesn't create any objects with these varialbes, only pushes them between the code and database.



    //Unsure on what functionality can be implemented without a linked database being created before hand




    public string DisplayReview(string Title)
    {

        string returnReview = "";
        string addString = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();


        OleDbCommand myCommand = new OleDbCommand("SELECT DISTINCT Author, Review FROM Reviews WHERE Title = @Title", myConnection);
        myCommand.Parameters.AddWithValue("@Title", Title);



        OleDbDataReader reader = myCommand.ExecuteReader();
        while (reader.Read())
        {
            returnReview = reader.GetString(0);
            addString += "Author  " + returnReview + ":   ";
            returnReview = reader.GetString(1);
            addString += "  " + returnReview + "";
            addString += "\n";
            addString += "\n";

        }
        reader.Close();

        return addString;


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
            initialreturn = reader.GetString(2);
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

        if (titleInput != "")
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE Title = @InputTitle AND DateofPlay = @InputDate", myConnection);
            myCommand.Parameters.AddWithValue("@InputTitle", titleInput);
            myCommand.Parameters.AddWithValue("@InputDate", dateInput);
            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {



                title = reader.GetString(0);
                time = reader.GetString(2);



                comboValue.Add(title);
                timeBoxValue.Add(time);



            }
        }




        myConnection.Close();


    }

    public string searchGenre(string input)
    {
        string inputString = input;
        string returnAllPlays = "";
        string initialreturn = "";
        string addString = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();


        OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE Genre = @Input", myConnection);
        myCommand.Parameters.AddWithValue("@Input", input);

        OleDbDataReader reader = myCommand.ExecuteReader();
        while (reader.Read())
        {
            initialreturn = reader.GetString(0);

            addString += "Title: " + initialreturn + "  ";
            initialreturn = reader.GetDateTime(1).ToShortDateString();
            addString += "Date: " + initialreturn + "  ";
            initialreturn = reader.GetString(2);
            addString += "Time: " + initialreturn + "\n";
            addString += "\n";
            addString += "\n";


        }


        myConnection.Close();

        returnAllPlays = addString;

        return returnAllPlays;

    }


    public string SearchPlaysUpdate(string input, DateTime dateInput)
    {
        DateTime inputDateTime = dateInput;
        string Inputstring = input;
        string returnAllPlays = "";
        string initialreturn = "";
        string addString = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();

        if (title != "")
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE DateofPlay = @InputDate", myConnection);

            myCommand.Parameters.AddWithValue("@InputDate", inputDateTime);

            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                initialreturn = reader.GetString(0);

                addString += "Title: " + initialreturn + "  ";
                initialreturn = reader.GetDateTime(1).ToShortDateString();
                addString += "Date: " + initialreturn + "  ";
                initialreturn = reader.GetString(2);
                addString += "Time: " + initialreturn + "\n";
                addString += "\n";
                addString += "\n";


            }
        }


        else
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE Title = @InputTitle AND DateOfPlay = @Iputdate", myConnection);
            myCommand.Parameters.AddWithValue("@InputTitle", Inputstring);
            myCommand.Parameters.AddWithValue("@InputDate", inputDateTime);

            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                initialreturn = reader.GetString(0);

                addString += "Title: " + initialreturn + "  ";
                initialreturn = reader.GetDateTime(1).ToShortDateString();
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

    public void AddtoBasket(string userID, string PlayChosen, float Standard, float Child, float OAP, DateTime PlayDate, string Time, string Price, float Quantity)
    {



        string checkString;
        float checkValue;
        //needs to write to database 
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();

        OleDbCommand checkCommand = new OleDbCommand("SELECT TicketsQuantity FROM Plays WHERE Title = @Title AND DateOfPlay = @DateOfPlay AND TimeOfPlay = @TimeOfPlay", myConnection);

        checkCommand.Parameters.AddWithValue("@Title", PlayChosen);
        checkCommand.Parameters.AddWithValue("@DateOfPlay", PlayDate);
        checkCommand.Parameters.AddWithValue("@TimeOfPlay", Time);


        OleDbDataReader reader2 = checkCommand.ExecuteReader();

        while (reader2.Read())
        {
            checkString = reader2.GetString(0);
            checkValue = Convert.ToInt32(checkString);

            if ((checkValue - Quantity) >= 0)
            {
                OleDbCommand myCommand = new OleDbCommand("INSERT INTO [Basket] (UserID, PlayChosen, StandardNo, ChildNo, OAPNo, PlayDate, PlayTime, Price, Quantity) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)", myConnection);

                myCommand.Parameters.AddWithValue("@UserID", userID);
                myCommand.Parameters.AddWithValue("@PlayChosen", PlayChosen);
                myCommand.Parameters.AddWithValue("@Standard", Standard);
                myCommand.Parameters.AddWithValue("@Child", Child);
                myCommand.Parameters.AddWithValue("@OAP", OAP);
                myCommand.Parameters.AddWithValue("@PlayDate", PlayDate);
                myCommand.Parameters.AddWithValue("@PlayTime", Time);
                myCommand.Parameters.AddWithValue("@Price", Price);
                myCommand.Parameters.AddWithValue("@Quantity", Quantity);


                myCommand.ExecuteNonQuery();


                success = 1;



                OleDbCommand decrementCommand = new OleDbCommand("UPDATE Plays SET TicketsQuantity = @TicketsQuantity WHERE Title = @Title AND DateOfPlay = @DateOfPlay AND TimeOfPlay = @TimeOfPlay", myConnection);
                decrementCommand.Parameters.AddWithValue("@TicketsQuantity", (checkValue - Quantity));
                decrementCommand.Parameters.AddWithValue("@Title", PlayChosen);
                decrementCommand.Parameters.AddWithValue("@DateOfPlay", PlayDate);
                decrementCommand.Parameters.AddWithValue("@TimeOfPlay", Time);
                decrementCommand.ExecuteNonQuery();

            }

            else
            {
                success = 2;

            }




        }
        myConnection.Close();

    }

    public void addReview(string UserID, string Review, string Title)
    {
        string checkString;
        float checkValue;
        //needs to write to database 
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();



        OleDbCommand myCommand = new OleDbCommand("INSERT INTO Reviews (Author, Review, Title) VALUES (?, ?, ?)", myConnection);
        myCommand.Parameters.AddWithValue("@Author", UserID);
        myCommand.Parameters.AddWithValue("@Review", Review);
        myCommand.Parameters.AddWithValue("@Title", Title);


        myCommand.ExecuteNonQuery();
    }


    //Using both the title and its date as an identifier 

}