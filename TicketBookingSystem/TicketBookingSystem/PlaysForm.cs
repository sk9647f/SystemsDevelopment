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
            Play plays = new Play();

            InitializeComponent();

            AllPlaysl.Text = plays.DisplayPlays();
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
        

        public void SearchPlays()
        {
            DateTime dateInput = dateTimePicker2.Value;
            string titleInput = playTitleTextBox.Text;
            Play plays = new Play();
            plays.SearchPlays(titleInput, dateInput);



            comboBox1.DataSource = plays.comboValue;
            

            /*string returnAllPlays = "";
            string initialreturn = "";
            string addString = "";
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";


            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();

            for (int i = 0; i < 1; i++)
            {
                OleDbCommand myCommand = new OleDbCommand("SELECT DISTINCT Title, DateofPlay, TimeofPlay FROM Plays WHERE DateofPlay = @Input", myConnection);
                myCommand.Parameters.AddWithValue("@Input", dateTimePicker2.Value.ToString("dd/MM/yyyy"));
                OleDbDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    initialreturn = reader.GetString(0);
                    comboBox1.Items.Add(initialreturn);
                    addString += "Title: " + initialreturn + "  ";
                    initialreturn = reader.GetDateTime(1).ToShortDateString();
                    addString += "Date: " + initialreturn + "  ";
                    initialreturn = reader.GetDateTime(2).ToShortTimeString();
                    addString += "Time: " + initialreturn + "\n";
                    addString += "\n";
                    addString += "\n";


                }
            }

            myConnection.Close();

            returnAllPlays = addString;

            AllPlaysl.Text = returnAllPlays;
            */

        }

      

        private void AddBack_Click(object sender, EventArgs e)
        {
            Play plays = new Play();

            AllPlaysl.Text = plays.DisplayPlays();

            BookTickB.Visible = false;

            comboBox1.Visible = false;

            dateTimePicker2.Visible = true;

            SearchDateB.Visible = true;

            AddBack.Visible = false;

            AddBack.Visible = false;

            AllPlaysl.Visible = true;



        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Play plays = new Play();
            plays.DisplayReview();
        }

        private void PlaysForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketSysDBDataSet.Plays' table. You can move, or remove it, as needed.
            this.playsTableAdapter.Fill(this.ticketSysDBDataSet.Plays);

        }

       
        

        


        private void SearchDateB_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            SearchPlays();

            AddBack.Visible = true;

            

            BookTickB.Visible = true;

            comboBox1.Visible = true;
        }

        private void BookTickB_Click(object sender, EventArgs e)
        {

            BasketForm basketForm = new BasketForm();
            basketForm.ShowDialog();

            basketForm.setValues(comboBox1.Text, dateTimePicker2.Text);

            
        }




        //Using both the title and its date as an identifier 

    }
}
