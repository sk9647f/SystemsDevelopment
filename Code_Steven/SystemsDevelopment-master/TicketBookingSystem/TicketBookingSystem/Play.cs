using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

public class Play

{
   
    public string title;
    public int success;
    public float checkValue;
    string time;
    public List <string> comboValue = new List<string>();
    public List<string> timeBoxValue = new List<string>();
   

    public string DisplayPlays()
    {

        string returnAllPlays = "";
        string initialreturn = "";
        string addString = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

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
        string previousTitle = "";

        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();

        if (titleInput != "" || titleInput!= null)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE Title = @InputTitle AND DateofPlay = @InputDate", myConnection);
            myCommand.Parameters.AddWithValue("@InputTitle", titleInput);
            myCommand.Parameters.AddWithValue("@InputDate", dateInput);
            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {



                title = reader.GetString(0);
                time = reader.GetString(2);

                
                if(title != previousTitle)
                {
                    comboValue.Add(title);
                    previousTitle = title;
                }
                    
                

                
                timeBoxValue.Add(time);



            }
        }
        else if(titleInput == "" || titleInput == null)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE DateofPlay = @InputDate", myConnection);
            
            myCommand.Parameters.AddWithValue("@InputDate", dateInput);
            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {



                title = reader.GetString(0);
                time = reader.GetString(2);


                if (title != previousTitle)
                {
                    comboValue.Add(title);
                    previousTitle = title;
                }




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
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

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


    public string SearchPlaysUpdate(string input, DateTime dateInput )
    {
        DateTime inputDateTime = dateInput;
        string Inputstring = input;
        string returnAllPlays = "";
        string initialreturn = "";
        string addString = "";
        string previousTitle = "";
        string connString;
        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

        OleDbConnection myConnection = new OleDbConnection(connString);
        myConnection.Open();

        if (input != "" || input != null)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE DateofPlay = @InputDate AND Title = @InputTitle ", myConnection);
            
            myCommand.Parameters.AddWithValue("@InputDate", inputDateTime);
            myCommand.Parameters.AddWithValue("@InputTitle", input);

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

                title = reader.GetString(0);
                time = reader.GetString(2);

                if(title != previousTitle)
                {
                    comboValue.Add(title);
                    previousTitle = title;
                }
                

                timeBoxValue.Add(time);


            }
        }

        
        else if(input == "" || input == null)
        {
            OleDbCommand myCommand = new OleDbCommand("SELECT Title, DateofPlay, TimeofPlay FROM Plays WHERE DateOfPlay = @Iputdate", myConnection);
            
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

                title = reader.GetString(0);

                if (title != previousTitle)
                {
                    comboValue.Add(title);
                    previousTitle = title;
                }

            }
        }

        myConnection.Close();

        returnAllPlays = addString;

        //AllPlaysl.Text = returnAllPlays;
        return returnAllPlays;

    }

   

    //Using both the title and its date as an identifier 

}
