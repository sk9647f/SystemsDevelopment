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
        public List<string> Orderlist = new List<string>();
        public List<string> Reset = new List<string>();
        public string title;
        public string date;
        public double checkdouble;
        public float discountValue = 1;
        bool discount1 = false;
        bool discount2 = false;
        bool discount3 = false;

        public BasketForm()
        {

            if (Account.LoginUsername != null)
            {
                InitializeComponent();
                updateScreen();
            }
            else
            {
                MessageBox.Show("Please Login to Continue");
            }
            
        }

        public void updateScreen()
        {
            string LoginUsername = Account.LoginUsername;
            if (LoginUsername != null)
            {
                object[] meta = new object[1];
                bool read = true;
                string connString;
                connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = F:\Year 2\Systems Development\Coursework\SystemsDevelopment-master\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

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
                        int orderID = reader.GetInt32(0);
                        string play = reader.GetString(2);
                        DateTime date = reader.GetDateTime(6);
                        string datestring = date.ToShortDateString();
                        string time = reader.GetString(7);
                        float price = reader.GetInt32(8);
                        int quantity = reader.GetInt32(9);
                        string TicketType = reader.GetString(3);


                        {
                            Orderlist.Add(orderID + "");
                            Listl.Text += orderID + "      " + play + "     " + datestring + "    " + time + "    £" + price + "    " + "\n" + "\n" + "\n";
                            OrderBox.Items.Add(orderID);
                        }

                        Console.WriteLine();
                        read = reader.Read();
                    } while (read == true);
                }
                reader.Close();



            }



            else
            {
                MessageBox.Show("Please Login to Continue");
            }
        }
            


        public void resetCombo()
        {
            OrderBox.DataSource = null;
            for (int i = 1; i < 100; i++)
            {
                
                
            }
        }

        private void DeleteOrderB_Click(object sender, EventArgs e)
        {
            ChosenPlays basket = new ChosenPlays();
            
            basket.RemoveFromBasket(OrderBox.Text);
            MessageBox.Show("Removed item from basket");
            Listl.Text = "";
            OrderBox.Items.Clear();
            OrderBox.Text = "";
            updateScreen();
        }

        private void Confirmb_Click(object sender, EventArgs e)
        {
            /*ChosenPlays basket = new ChosenPlays();
            
            basket.Checkout(OrderBox.Text);
            Listl.Text = "";
            OrderBox.Items.Clear();
            OrderBox.Text = "";
            updateScreen();*/

            panel1.Visible = true;

            DeleteOrderB.Visible = false;
            Confirmb.Visible = false;
            Listl.Visible = false;
            OrderBox.Visible = false;
            ChosenPlays basket = new ChosenPlays();

           ConfirmDetailsl.Text = basket.Order(OrderBox.Text,Account.LoginUsername);
            if(basket.quantity > 20)
            {
                discountValue = discountValue - 0.05f;
            }
           FinalPricel.Text = "Final Price =  £" + (basket.checkValue*discountValue);
            checkdouble = basket.checkValue;

        }

        private void InputDiscountb_Click(object sender, EventArgs e)

        {
            

            if (DiscountBox.Text == "Discount" && discount1 == false)
            {
                
                discountValue = discountValue - 0.1f;
                if (checkdouble * discountValue < 4)
                {
                    FinalPricel.Text = "Final Price =  £10";
                    discount1 = true;
                }
                else
                {
                    FinalPricel.Text = "Final Price =  £" + (checkdouble * discountValue);
                    discount1 = true;
                }
            }

            if (DiscountBox.Text == "Discount" && discount1 == true)
            {
                MessageBox.Show ("Code Applied");
            }





                if (DiscountBox.Text == "1" && discount2 == false)
            {

                discountValue = discountValue - 0.2f;
                if (checkdouble * discountValue < 4)
                {
                    FinalPricel.Text = "Final Price =  £4";
                    discount2 = true;
                }
                else
                {
                    FinalPricel.Text = "Final Price =  £" + (checkdouble * discountValue);
                    discount2 = true;
                }
            }
            if (DiscountBox.Text == "1" && discount2 == true)
            {
                MessageBox.Show("Code Applied");
            }


            if (DiscountBox.Text == "2" && discount3 == false)
            {

                discountValue = discountValue -  0.3f;
                if (checkdouble * discountValue < 4)
                {
                    FinalPricel.Text = "Final Price =  £4";
                    discount3 = true;
                }
                else
                {
                    FinalPricel.Text = "Final Price =  £" + (checkdouble * discountValue);
                    discount3 = true;
                }

            }



            if (DiscountBox.Text == "2" && discount3 == true)
            {
                MessageBox.Show("Code Applied");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChosenPlays basket = new ChosenPlays();
            //MessageBox.Show(basket.checkEmail(Account.LoginUsername));
            basket.Checkout(OrderBox.Text, (checkdouble*discountValue));
            MessageBox.Show("Play Booked");
            string login = Account.LoginUsername;
            string reciept = basket.checkEmail(login);
            MessageBox.Show(reciept);

            basket.RemoveFromBasket(OrderBox.Text);
            Listl.Text = "";
            OrderBox.Items.Clear();
            OrderBox.Text = "";
            updateScreen();


            panel1.Visible = false;
            DeleteOrderB.Visible = true;
            Confirmb.Visible = true;
            Listl.Visible = true;
            OrderBox.Visible = true;
            
        }

        private void Backb_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            DeleteOrderB.Visible = true;
            Confirmb.Visible = true;
            Listl.Visible = true;
            OrderBox.Visible = true;
        }
    }
}

