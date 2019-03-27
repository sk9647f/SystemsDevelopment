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
        float currTotal;
        int DayInt;


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


            TimeBox.DataSource = plays.timeBoxValue;
            comboBox1.DataSource = plays.comboValue;


            /*string returnAllPlays = "";
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

            panel1.Visible = false;

            TimeBox.Visible = false;

            SearchGenreb.Visible = true;

            SearchGenrel.Visible = true;

            comboBox2.Visible = true;

            playTitleTextBox.Visible = true;

            PlayTitlel.Visible = true;

            ReviewTextBox.Visible = false;

            ReviewsWriteB.Visible = false;

            ReviewsReadb.Visible = false;

            ConfirmReview.Visible = false;

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
            Play plays = new Play();

            AllPlaysl.Text = plays.SearchPlaysUpdate(playTitleTextBox.Text, dateTimePicker2.Value);

            AddBack.Visible = true;



            BookTickB.Visible = true;

            comboBox1.Visible = true;
            TimeBox.Visible = true;
            ReviewsReadb.Visible = true;
            ReviewsWriteB.Visible = true;
        }

        private void BookTickB_Click(object sender, EventArgs e)
        {

            BasketForm basketForm = new BasketForm();
            basketForm.ShowDialog();

            basketForm.setValues(comboBox1.Text, dateTimePicker2.Text);


        }


        private void BookTickB_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            AllPlaysl.Visible = false;
            SearchDateB.Visible = false;
            playTitleTextBox.Visible = false;
            PlayTitlel.Visible = false;
            SearchGenreb.Visible = false;
            SearchGenrel.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            BookTickB.Visible = false;
            PlayDatel.Visible = false;
            ReviewsReadb.Visible = false;
            DayInt = (int)dateTimePicker2.Value.DayOfWeek;
            if (DayInt <= 4)
            {
                StandardPl.Text = "£18";
                ChildPl.Text = "£13.50";
                OAPPl.Text = "£9";
            }
            else
            {
                StandardPl.Text = "£20";
                ChildPl.Text = "£15";
                OAPPl.Text = "£10";
            }

            CurrTotal.Text = "Current Total: £ ";
            BookTitlel.Text = playTitleTextBox.Text;
            BookDatel.Text = dateTimePicker2.Text;
            BookTimel.Text = TimeBox.Text;


        }

        private void RadioBandB_CheckedChanged(object sender, EventArgs e)
        {
            if (DayInt < 4)
            {
                float Stand = Convert.ToInt32(StandardUpDn.Value);
                float Child = Convert.ToInt32(ChildUpDn.Value);
                float OAP = Convert.ToInt32(OAPUpDn.Value);
                if (RadioBandA.Checked)
                {
                    currTotal = (Stand * 20) + (Child * 15) + (OAP * 10);
                    CurrTotal.Text = "£ " + currTotal;
                }
                if (RadioBandB.Checked)
                {
                    currTotal = (Stand * 15) + (Child * 10) + (OAP * 5);
                    CurrTotal.Text = "£ " + currTotal;
                }
                if (RadioBandC.Checked)
                {
                    currTotal = (Stand * 15) + (Child * 5) + (OAP * 5);
                    CurrTotal.Text = "£ " + currTotal;
                }
                if (RadioBandB.Checked == true)
                {
                    StandardPl.Text = "£WORKING" + "";
                    ChildPl.Text = "£10";
                    OAPPl.Text = "£5";
                }
            }
            else
            {
                float Stand = Convert.ToInt32(StandardUpDn.Value);
                float Child = Convert.ToInt32(ChildUpDn.Value);
                float OAP = Convert.ToInt32(OAPUpDn.Value);
                if (RadioBandA.Checked)
                {
                    currTotal = (Stand * 20) + (Child * 15) + (OAP * 10);
                    CurrTotal.Text = "£ " + currTotal;
                }
                if (RadioBandB.Checked)
                {
                    currTotal = (Stand * 15) + (Child * 10) + (OAP * 5);
                    CurrTotal.Text = "£ " + currTotal;
                }
                if (RadioBandC.Checked)
                {
                    currTotal = (Stand * 15) + (Child * 5) + (OAP * 5);
                    CurrTotal.Text = "£ " + currTotal;
                }
                if (RadioBandB.Checked == true)
                {
                    StandardPl.Text = "£15";
                    ChildPl.Text = "£10";
                    OAPPl.Text = "£5";
                }
            }
        }

        private void RadioBandA_CheckedChanged(object sender, EventArgs e)
        {
            float Stand = Convert.ToInt32(StandardUpDn.Value);
            float Child = Convert.ToInt32(ChildUpDn.Value);
            float OAP = Convert.ToInt32(OAPUpDn.Value);
            if (RadioBandA.Checked)
            {
                currTotal = (Stand * 20) + (Child * 15) + (OAP * 10);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandB.Checked)
            {
                currTotal = (Stand * 15) + (Child * 10) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandC.Checked)
            {
                currTotal = (Stand * 15) + (Child * 5) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandA.Checked == true)
            {
                StandardPl.Text = "£20";
                ChildPl.Text = "£15";
                OAPPl.Text = "£10";
            }
        }

        private void RadioBandC_CheckedChanged(object sender, EventArgs e)
        {

            float Stand = Convert.ToInt32(StandardUpDn.Value);
            float Child = Convert.ToInt32(ChildUpDn.Value);
            float OAP = Convert.ToInt32(OAPUpDn.Value);
            if (RadioBandA.Checked)
            {
                currTotal = (Stand * 20) + (Child * 15) + (OAP * 10);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandB.Checked)
            {
                currTotal = (Stand * 15) + (Child * 10) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandC.Checked)
            {
                currTotal = (Stand * 15) + (Child * 5) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandC.Checked == true)
            {
                StandardPl.Text = "£10";
                ChildPl.Text = "£5";
                OAPPl.Text = "£5";
            }
        }

        private void StandardUpDn_ValueChanged(object sender, EventArgs e)
        {
            float Stand = Convert.ToInt32(StandardUpDn.Value);
            float Child = Convert.ToInt32(ChildUpDn.Value);
            float OAP = Convert.ToInt32(OAPUpDn.Value);
            if (RadioBandA.Checked)
            {
                currTotal = (Stand * 20) + (Child * 15) + (OAP * 10);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandB.Checked)
            {
                currTotal = (Stand * 15) + (Child * 10) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandC.Checked)
            {
                currTotal = (Stand * 15) + (Child * 5) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
        }

        private void ChildUpDn_ValueChanged(object sender, EventArgs e)
        {
            float Stand = Convert.ToInt32(StandardUpDn.Value);
            float Child = Convert.ToInt32(ChildUpDn.Value);
            float OAP = Convert.ToInt32(OAPUpDn.Value);
            if (RadioBandA.Checked)
            {
                currTotal = (Stand * 20) + (Child * 15) + (OAP * 10);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandB.Checked)
            {
                currTotal = (Stand * 15) + (Child * 10) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandC.Checked)
            {
                currTotal = (Stand * 15) + (Child * 5) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
        }

        private void OAPUpDn_ValueChanged(object sender, EventArgs e)
        {
            float Stand = Convert.ToInt32(StandardUpDn.Value);
            float Child = Convert.ToInt32(ChildUpDn.Value);
            float OAP = Convert.ToInt32(OAPUpDn.Value);
            if (RadioBandA.Checked)
            {
                currTotal = (Stand * 20) + (Child * 15) + (OAP * 10);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandB.Checked)
            {
                currTotal = (Stand * 15) + (Child * 10) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
            if (RadioBandC.Checked)
            {
                currTotal = (Stand * 15) + (Child * 5) + (OAP * 5);
                CurrTotal.Text = "£ " + currTotal;
            }
        }

        private void BookConfb_Click(object sender, EventArgs e)
        {
            float Stand = Convert.ToInt32(StandardUpDn.Value);
            float Child = Convert.ToInt32(ChildUpDn.Value);
            float OAP = Convert.ToInt32(OAPUpDn.Value);
            float Quantity = Stand + Child + OAP;

            Play plays = new Play();
            CheckValuel.Text = plays.checkValue.ToString();
            plays.AddtoBasket("User1", BookTitlel.Text, Stand, Child, OAP, dateTimePicker2.Value, BookTimel.Text, CurrTotal.Text, Quantity);
            if (plays.success == 1)
            {

                MessageBox.Show("Your tickets were booked successfully");
                CheckValuel.Text = plays.checkValue.ToString();



            }
            else if (plays.success == 2)
            {
                MessageBox.Show("You booked more seats than are available");
                CheckValuel.Text = plays.checkValue.ToString();
            }
            StandardUpDn.Value = 0;
            ChildUpDn.Value = 0;
            OAPUpDn.Value = 0;



        }

        private void ReviewsWriteB_Click(object sender, EventArgs e)
        {
            ReviewsWriteB.Visible = false;
            ReviewTextBox.Visible = true;
            ConfirmReview.Visible = true;

            ReviewsReadb.Visible = false;

            panel1.Visible = false;

            comboBox1.Visible = false;

            comboBox2.Visible = false;

            PlayTitlel.Visible = false;

            PlayDatel.Visible = false;

            playTitleTextBox.Visible = false;

            dateTimePicker2.Visible = false;

            TimeBox.Visible = false;

            BookTickB.Visible = false;

            SearchDateB.Visible = false;

            SearchGenreb.Visible = false;

            SearchGenrel.Visible = false;

            AllPlaysl.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play plays = new Play();
            AllPlaysl.Text = plays.DisplayReview(comboBox1.Text);
        }



        private void SearchGenreb_Click(object sender, EventArgs e)
        {
            Play plays = new Play();

            AllPlaysl.Text = plays.searchGenre(comboBox2.Text);

        }

        private void ConfirmReview_Click(object sender, EventArgs e)
        {
            Play plays = new Play();
            if (ReviewTextBox.Text != "")
            {
                plays.addReview("User1", ReviewTextBox.Text, comboBox1.Text);
                ReviewTextBox.Clear();
            }
            if (ReviewTextBox.Text == "")
            {
                MessageBox.Show("The textbox can't be left empty for a review");
            }
        }


        //Using both the title and its date as an identifier 

    }
}