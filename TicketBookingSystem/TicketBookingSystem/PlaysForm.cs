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
                string returnAllPlays = "";
                string initialreturn = "";
                string addString = "";
                string connString;
                connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";


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
                Play plays = new Play();
                
                AllPlaysl.Text = plays.DisplayPlays();

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

                AddBack.Visible = false;

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
                Play play = new Play();

                play.AddPlay(Titlet.Text, Genret.Text, Descriptiont.Text, Datet.Text, Timet.Text, TicketsAvat.Text, TicketQuant.Text);

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
                Play plays = new Play();
                plays.DisplayReview();
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
            Play play = new Play();
            play.DeletePlay(Titlet.Text, PlayIDt.Text);
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
            Play play = new Play();
            play.EditPlayFields("Title", Titlet.Text, PlayIDt.Text);
            }

            private void EditGenreB_Click(object sender, EventArgs e)
            {
            Play play = new Play();
            play.EditPlayFields("Title", Genret.Text, PlayIDt.Text);
        }

            private void EditDescripB_Click(object sender, EventArgs e)
            {
            Play play = new Play();
            play.EditPlayFields("Title", Descriptiont.Text, PlayIDt.Text);
        }

            private void EditDateB_Click(object sender, EventArgs e)
            {
            Play play = new Play();
            play.EditPlayFields("Title", Datet.Text, PlayIDt.Text);
        }

            private void EditTimeB_Click(object sender, EventArgs e)
            {
            Play play = new Play();
            play.EditPlayFields("Title", Timet.Text, PlayIDt.Text);
        }

            private void EditTiAvB_Click(object sender, EventArgs e)
            {
            Play play = new Play();
            play.EditPlayFields("Title", TicketsAvat.Text, PlayIDt.Text);
        }

            private void EditTiQuB_Click(object sender, EventArgs e)
            {
            Play play = new Play();
            play.EditPlayFields("Title", TicketQuant.Text, PlayIDt.Text);
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

        private void BookTickB_Click(object sender, EventArgs e)
        {   
            
            BasketForm  basketForm = new BasketForm();
            basketForm.setValues(comboBox1.Text, dateTimePicker2.Text); 
            
            basketForm.ShowDialog();
        }




        //Using both the title and its date as an identifier 

    }
    }

