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
    public partial class BasketForm : Form
    {

        public string title;
        public string date;
        
        public BasketForm()
        {
            InitializeComponent();
            

            string LoginUsername = "User1";
            object[] meta = new object[1];
            bool read = true;
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [Basket] WHERE [UserID] = @Username", myConnection);

            myCommand.Parameters.AddWithValue("@Username", LoginUsername);

            OleDbDataReader reader = myCommand.ExecuteReader();

            if (reader.Read() == true)
            {
                do
                {
                    int NumberOfColums = reader.GetValues(meta);
                    int NumberOfRows = reader.GetValues(meta);
                    string play = reader.GetString(2);
                    int quantity = reader.GetInt32(6);
                    string TicketType = reader.GetString(3);

                    {
                        for (int j = 0; j < NumberOfRows; j++)
                            if (TicketType == "<div>Standard</div>" || TicketType == "Standard")
                            {
                                numericUpDown1.Value += quantity;
                            }
                            else if (TicketType == "<div>Child</div>" || TicketType == "Child")
                            {
                                numericUpDown2.Value += quantity;
                            }
                            else if (TicketType == "<div>OAP</div>" || TicketType == "OAP")
                            {
                                numericUpDown3.Value += quantity;
                            }
                    }

                    Console.WriteLine();
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Stand = Convert.ToInt32(numericUpDown1.Value);
            int Child = Convert.ToInt32(numericUpDown2.Value);
            int OAP = Convert.ToInt32(numericUpDown3.Value);
            
            if (TotalBox.Text == "")
            {
                int Total = (Stand * 8) + (Child * 3) + (OAP * 4);
                TotalBox.Text += Total;
            }
            else
            {
                
                TotalBox.Text = "";
                int Total = (Stand * 8) + (Child * 3) + (OAP * 4);
                TotalBox.Text += Total;
            }
        }

        public void setValues(string titleinput, string dateinput)
        {
            // titleinput = title;
            Datel.Text = dateinput;
            Titlel.Text = titleinput;
        }


        
            
        private void button2_Click(object sender, EventArgs e)
        {
            int Stand = Convert.ToInt32(numericUpDown1.Value);
            int Child = Convert.ToInt32(numericUpDown2.Value);
            int OAP = Convert.ToInt32(numericUpDown3.Value);
            ChosenPlays basket = new ChosenPlays();
            int price = 0;
            int quantity = 0;

            price = (Stand * 8) + (Child * 3) + (OAP * 4);
            quantity = (Stand + Child + OAP);
            basket.AddToOrder("UserID", Titlel.Text, price, quantity, Convert.ToDateTime(Datel.Text), "test");


            numericUpDown1.Visible = false;
            numericUpDown2.Visible = false;
            numericUpDown3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            UpdateFinalB.Visible = true;
            BackB.Visible = true;
            Datel.Visible = false;
            Titlel.Visible = false;
            ConfirmB.Visible = true;
            Detailsl.Visible = true;


            Detailsl.Text = "Title: " + Titlel.Text + "   Date:  " + Datel.Text + "   Total Price = £" + price + "\n" + numericUpDown1.Value + "  Standard Tickets  " + numericUpDown2.Value + "  Child Tickets  +" + numericUpDown3.Value + "  OAP Tickets" ;


        }

        private void BackB_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            UpdateFinalB.Visible = false;
            Datel.Visible = true;
            Titlel.Visible = true;
            ConfirmB.Visible = false;
            Detailsl.Visible = false;
        }
    }
}

