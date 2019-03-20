using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace TicketBookingSystem
{
    public partial class PlaysForm : Form
    {
        public PlaysForm()
        {
            
            InitializeComponent();
            
            DisplayPlays();
        }
    
       
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

        public void AddPlay(/*string addTitle, string addGenre, string addDescription, string addDateOfPlay, string addTimeOfPlay, string addTicketsAvailable, string addTicketsQuantity*/)
        {
            //playID = 1;
            title = Titlet.Text;
            genre = Genret.Text;
            description = Descriptiont.Text;
            date = Datet.Text;
            time = Timet.Text;
            ticketsAvailable = TicketsAvat.Text;
            ticketsQuantity = TicketQuant.Text;



            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-200319fin\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
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

        public void EditPlayFields(string Input)
        {
            string InputField = Input;
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-200319fin\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            

            
            

            if(InputField == "Title")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET Title = @Change WHERE PlayID = @PlayID", myConnection);
                myCommand.Parameters.AddWithValue("@Change", Titlet.Text);
                myCommand.Parameters.AddWithValue("@PlayID", PlayIDt.Text);
                myCommand.ExecuteNonQuery();
            }
            if (InputField == "Description")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET Description = @Change WHERE PlayID = @PlayID", myConnection);
                myCommand.Parameters.AddWithValue("@Change", Descriptiont.Text);
                myCommand.Parameters.AddWithValue("@PlayID", PlayIDt.Text);
                myCommand.ExecuteNonQuery();
            }
            if (InputField == "Genre")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET Genre = @Change WHERE PlayID = @PlayID", myConnection);
                myCommand.Parameters.AddWithValue("@Change", Genret.Text);
                myCommand.Parameters.AddWithValue("@PlayID", PlayIDt.Text);
                myCommand.ExecuteNonQuery();
            }
            if (InputField == "DateOfPlay")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET DateOfPlay = @Change WHERE PlayID = @PlayID", myConnection);
                myCommand.Parameters.AddWithValue("@Change", Datet.Text);
                myCommand.Parameters.AddWithValue("@PlayID", PlayIDt.Text);
                myCommand.ExecuteNonQuery();
            }
            if (InputField == "TimeOfPlay")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET TimeOfPlay = @Change WHERE PlayID = @PlayID", myConnection);
                myCommand.Parameters.AddWithValue("@Change", Timet.Text);
                myCommand.Parameters.AddWithValue("@PlayID", PlayIDt.Text);
                myCommand.ExecuteNonQuery();

            }
            if (InputField == "TicketsAvailable")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET TicketsAvailable = @Change WHERE PlayID = @PlayID", myConnection);
                myCommand.Parameters.AddWithValue("@Change", TicketsAvat.Text);
                myCommand.Parameters.AddWithValue("@PlayID", PlayIDt.Text);
                myCommand.ExecuteNonQuery();
            }
            if (InputField == "TicketsQuantity")
            {
                OleDbCommand myCommand = new OleDbCommand("UPDATE Plays SET TicketsQuantity = @Change WHERE PlayID = @PlayID", myConnection);
                myCommand.Parameters.AddWithValue("@Change", TicketQuant.Text);
                myCommand.Parameters.AddWithValue("@PlayID", PlayIDt.Text);
                myCommand.ExecuteNonQuery();
            }




            
            myConnection.Close();
        }

        public void DeletePlay()
        {


            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-200319fin\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";
            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();

            OleDbCommand myCommand = new OleDbCommand("DELETE FROM Plays WHERE Title = @Title  AND PlayID = @PlayID ", myConnection);
            myCommand.Parameters.AddWithValue("@Title", Titlet.Text);
            myCommand.Parameters.AddWithValue("@PlayID", PlayIDt.Text);

            myCommand.ExecuteNonQuery();
            myConnection.Close();

            //May need more identifiers to prevent clashes
        }

        public string DisplayReview(/*string readTitle, string readDate*/)
        {
            string input = Genret.Text;
            string returnReview = "";
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-200319fin\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";


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


        }

        public string DisplayPlays()
        {
            
            string returnAllPlays = "";
            string initialreturn ="";
            string addString = "";
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-200319fin\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";


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

            AllPlaysl.Text = returnAllPlays;
            return returnAllPlays;
            
        }

        public void SearchPlays()
        {
            string returnAllPlays = "";
            string initialreturn = "";
            string addString = "";
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\Code\SystemsDevelopment-200319fin\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";


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

        private void AddPlay1_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = false;

            SearchDateB.Visible = false;

            EditPlayB.Visible = false;

            AddPlay1.Visible = false;

            AddBack.Visible = true;

            DeletePlayB.Visible = false;

            TitleL.Visible = true;

            Titlet.Visible = true;

            Genrel.Visible = true;
            
            Genret.Visible = true;

            Descriptionl.Visible = true;

            Descriptiont.Visible = true;

            Datel.Visible = true;

            Datel.Visible = true;

            Datet.Visible = true;

            Timel.Visible = true;

            Timet.Visible = true;

            TicketsAval.Visible = true;

            TicketsAvat.Visible = true;

            TicketQuanl.Visible = true;

            TicketQuant.Visible = true;

            InputNewPlay.Visible = true;

            AddBack.Visible = true;

            AllPlaysl.Visible = false;


            
        }

        private void AddBack_Click(object sender, EventArgs e)
        {
            DisplayPlays();

            BookTickB.Visible = false;

            comboBox1.Visible = false;

            dateTimePicker2.Visible = true;

            SearchDateB.Visible = true;

            EditPlayB.Visible = true;

            AddPlay1.Visible = true;

            AddBack.Visible = false;

            PlayIDl.Visible = false;

            PlayIDt.Visible = false;

            TitleL.Visible = false;

            Titlet.Visible = false;

            Genrel.Visible = false;

            Genret.Visible = false;

            Descriptionl.Visible = false;

            Descriptiont.Visible = false;

            Datel.Visible = false;

            Datel.Visible = false;

            Datet.Visible = false;

            Timel.Visible = false;

            Timet.Visible = false;

            TicketsAval.Visible = false;

            TicketsAvat.Visible = false;

            TicketQuanl.Visible = false;

            TicketQuant.Visible = false;

            InputNewPlay.Visible = false;

            AddBack.Visible =  false;

            AllPlaysl.Visible = true;

            DeletePlayB.Visible = true;

            DeleteConfB.Visible = false;

            EditTitleB.Visible = false;

            EditGenreB.Visible = false;

            EditDescripB.Visible = false;

            EditDateB.Visible = false;

            EditTimeB.Visible = false;

            EditTiQuB.Visible = false;

            EditTiAvB.Visible = false;



        }

        private void InputNewPlay_Click(object sender, EventArgs e)
        {

            AddPlay();

            Titlet.Text = "";

            Descriptiont.Text = "";

            Genret.Text = "";

            Timet.Text = "";

            Datet.Text = "";

            TicketsAvat.Text = "";

            TicketQuant.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayReview();
        }

        private void PlaysForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketSysDBDataSet.Plays' table. You can move, or remove it, as needed.
            this.playsTableAdapter.Fill(this.ticketSysDBDataSet.Plays);

        }

        private void DeletePlayB_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = false;

            SearchDateB.Visible = false;

            AddPlay1.Visible = false;

            DeletePlayB.Visible = false;

            DeleteConfB.Visible = true;

            PlayIDl.Visible = true;

            PlayIDt.Visible = true;

            TitleL.Visible = true;

            Titlet.Visible = true;

            AddBack.Visible = true;

            InputNewPlay.Visible = false;

            AllPlaysl.Visible = false;

            EditPlayB.Visible = false;
        }

        private void DeleteConfB_Click(object sender, EventArgs e)
        {
            DeletePlay();
            Titlet.Clear();
            PlayIDt.Clear();
        }

        private void EditPlayB_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = false;

            SearchDateB.Visible = false;

            EditPlayB.Visible = false;

            AddPlay1.Visible = false;

            AddBack.Visible = true;

            DeletePlayB.Visible = false;

            PlayIDl.Visible = true;

            PlayIDt.Visible = true;

            TitleL.Visible = true;

            Titlet.Visible = true;

            Genrel.Visible = true;

            Genret.Visible = true;

            Descriptionl.Visible = true;

            Descriptiont.Visible = true;

            Datel.Visible = true;

            Datel.Visible = true;

            Datet.Visible = true;

            Timel.Visible = true;

            Timet.Visible = true;

            TicketsAval.Visible = true;

            TicketsAvat.Visible = true;

            TicketQuanl.Visible = true;

            TicketQuant.Visible = true;

            AddBack.Visible = true;

            AllPlaysl.Visible = false;

            EditTitleB.Visible = true;

            EditGenreB.Visible = true;

            EditDescripB.Visible = true;

            EditDateB.Visible = true;

            EditTimeB.Visible = true;

            EditTiQuB.Visible = true;

            EditTiAvB.Visible = true;



        }

        private void EditTitleB_Click(object sender, EventArgs e)
        {
            EditPlayFields("Title");
        }

        private void EditGenreB_Click(object sender, EventArgs e)
        {
            EditPlayFields("Genre");
        }

        private void EditDescripB_Click(object sender, EventArgs e)
        {
            EditPlayFields("Description");
        }

        private void EditDateB_Click(object sender, EventArgs e)
        {
            EditPlayFields("DateOfPlay");
        }

        private void EditTimeB_Click(object sender, EventArgs e)
        {
            EditPlayFields("TimeOfPlay");
        }

        private void EditTiAvB_Click(object sender, EventArgs e)
        {
            EditPlayFields("TicketsAvailable");
        }

        private void EditTiQuB_Click(object sender, EventArgs e)
        {
            EditPlayFields("TicketsQuantity");
        }

        private void SearchDateB_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SearchPlays();

            AddBack.Visible = true;

            DeletePlayB.Visible = false;

            AddPlay1.Visible = false;

            EditPlayB.Visible = false;

            BookTickB.Visible = true;

            comboBox1.Visible = true;
        }




        //Using both the title and its date as an identifier 

    }
}

