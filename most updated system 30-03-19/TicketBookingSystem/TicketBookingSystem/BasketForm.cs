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

        string play1 = "Hamlet";
        string play2 = "Lion King";
        string play3 = "Macbeth";

        float cost1, cost2, cost3, cost4, cost5, cost6, cost7, cost8, cost9;

        private void ConfirmB_Click(object sender, EventArgs e)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            OleDbCommand myCommand = new OleDbCommand("DELETE FROM [Basket] WHERE Username = @Username", myConnection);
            myCommand.Parameters.AddWithValue("@Username", loginUserName);

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        private void UpdateFinalB_Click(object sender, EventArgs e)
        {
                int Stand1 = Convert.ToInt32(numericUpDown1.Value);
                int Child1 = Convert.ToInt32(numericUpDown2.Value);
                int OAP1 = Convert.ToInt32(numericUpDown3.Value);
                float cost1 = float.Parse(costl1.Text);
                float cost2 = float.Parse(costl2.Text);
                float cost3 = float.Parse(costl3.Text);
                float Subtotal1 = (cost1 * Stand1) + (cost2 * Child1) + (cost3 * OAP1);
                subtotal1.Text = Convert.ToString(Subtotal1);

                int Stand2 = Convert.ToInt32(numericUpDown4.Value);
                int Child2 = Convert.ToInt32(numericUpDown5.Value);
                int OAP2 = Convert.ToInt32(numericUpDown6.Value);
                float cost4 = float.Parse(costl4.Text);
                float cost5 = float.Parse(costl5.Text);
                float cost6 = float.Parse(costl6.Text);
                float Subtotal2 = (cost4 * Stand2) + (cost5 * Child2) + (cost6 * OAP2);
                subtotal2.Text = Convert.ToString(Subtotal2);

                int Stand3 = Convert.ToInt32(numericUpDown7.Value);
                int Child3 = Convert.ToInt32(numericUpDown8.Value);
                int OAP3 = Convert.ToInt32(numericUpDown9.Value);
                float cost7 = float.Parse(costl7.Text);
                float cost8 = float.Parse(costl8.Text);
                float cost9 = float.Parse(costl9.Text);
                float Subtotal3 = (cost7 * Stand3) + (cost8 * Child3) + (cost9 * OAP3);
                subtotal3.Text = Convert.ToString(Subtotal3);

                if (TotalBox.Text == "")
                {
                    TotalBox.Text = Convert.ToString(Subtotal1 + Subtotal2 + Subtotal3);
                }
                else
                {
                    TotalBox.Text = "";
                    TotalBox.Text = Convert.ToString(Subtotal1 + Subtotal2 + Subtotal3);
                }
           
        }

        //public string date;
        DateTime purchaseDate = DateTime.Now;
        string loginUserName = "Benj2";

        public BasketForm()
        {
            InitializeComponent();



            object[] meta = new object[1];
            bool read = true;
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [BASKET] WHERE [UserID] = @Username", myConnection);

            myCommand.Parameters.AddWithValue("@Username", loginUserName);

            OleDbDataReader reader = myCommand.ExecuteReader();

            if (reader.Read() == true)
            {
                do
                {
                    int NumberOfColums = reader.GetValues(meta);
                    int NumberOfRows = reader.GetValues(meta);
                    string play = reader.GetString(2);
                    string playtime = reader.GetString(7);
                    string Stand = reader.GetString(3);
                    string Child = reader.GetString(4);
                    string OAP = reader.GetString(5);
                    string date = reader.GetDateTime(6).ToString("yyyy-MM-dd");
                    int DayInt = (int)reader.GetDateTime(6).DayOfWeek;


                    {
                        for (int j = 0; j < NumberOfRows; j++)
                            if (play == play1)
                            {
                                playtitle1.Text = play1;
                                playdate1.Text = date;
                                playtime1.Text = playtime;
                                numericUpDown1.Value += Convert.ToInt32(Stand);
                                numericUpDown2.Value += Convert.ToInt32(Child);
                                numericUpDown3.Value += Convert.ToInt32(OAP);

                                if (DayInt <= 4)
                                {
                                    costl1.Text = "18";
                                    costl2.Text = "13.50";
                                    costl3.Text = "9";
                                }
                                else
                                {
                                    costl1.Text = "20";
                                    costl2.Text = "15";
                                    costl3.Text = "10";
                                }
                            }
                            else if (play == play2)
                            {
                                playtitle2.Text = play2;
                                playdate2.Text = date;
                                playtime2.Text = playtime;
                                numericUpDown4.Value += Convert.ToInt32(Stand);
                                numericUpDown5.Value += Convert.ToInt32(Child);
                                numericUpDown6.Value += Convert.ToInt32(OAP);

                                if (DayInt <= 4)
                                {
                                    costl4.Text = "18";
                                    costl5.Text = "13.50";
                                    costl6.Text = "9";
                                }
                                else
                                {
                                    costl4.Text = "20";
                                    costl5.Text = "15";
                                    costl6.Text = "10";
                                }
                            }
                            else if (play == play3)
                            {
                                playtitle3.Text = play1;
                                playdate3.Text = date;
                                playtime3.Text = playtime;
                                numericUpDown7.Value += Convert.ToInt32(Stand);
                                numericUpDown8.Value += Convert.ToInt32(Child);
                                numericUpDown9.Value += Convert.ToInt32(OAP);

                                if (DayInt <= 4)
                                {
                                    costl7.Text = "18";
                                    costl8.Text = "13.50";
                                    costl9.Text = "9";
                                }
                                else
                                {
                                    costl7.Text = "20";
                                    costl8.Text = "15";
                                    costl9.Text = "10";
                                }
                            }

                    }

                    Console.WriteLine();
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
        }
        //public BasketForm()
        //{

        //    if (Account.LoginUsername != null)
        //    {
        //        InitializeComponent();
        //        updateScreen();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Login to Continue");
        //    }
            
        //}

        //public void updateScreen()
        //{
        //    string LoginUsername = Account.LoginUsername;
        //    if (LoginUsername != null)
        //    {
        //        object[] meta = new object[1];
        //        bool read = true;
        //        string connString;
        //        connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = J:\Copy\TicketBookingSystemerdit\TicketBookingSystem\TicketSysDB.mdb";

        //        OleDbConnection myConnection = new OleDbConnection(connString);
        //        myConnection.Open();
        //        OleDbCommand myCommand = new OleDbCommand("SELECT * FROM [Basket] WHERE [UserID] = @Username", myConnection);

        //        myCommand.Parameters.AddWithValue("@Username", LoginUsername);

        //        OleDbDataReader reader = myCommand.ExecuteReader();

        //        if (reader.Read() == true)
        //        {
        //            do
        //            {
        //                int NumberOfColums = reader.GetValues(meta);
        //                int NumberOfRows = reader.GetValues(meta);
        //                int orderID = reader.GetInt32(0);
        //                string play = reader.GetString(2);
        //                DateTime date = reader.GetDateTime(6);
        //                string datestring = date.ToShortDateString();
        //                string time = reader.GetString(7);
        //                float price = reader.GetInt32(8);
        //                int quantity = reader.GetInt32(9);
        //                string TicketType = reader.GetString(3);


        //                {
        //                    Orderlist.Add(orderID + "");
        //                    Listl.Text += orderID + "      " + play + "     " + datestring + "    " + time + "    £" + price + "    " + "\n" + "\n" + "\n";
        //                    OrderBox.Items.Add(orderID);
        //                }

        //                Console.WriteLine();
        //                read = reader.Read();
        //            } while (read == true);
        //        }
        //        reader.Close();



        //    }



        //    else
        //    {
        //        MessageBox.Show("Please Login to Continue");
        //    }
        //}
            


        //public void resetCombo()
        //{
        //    OrderBox.DataSource = null;
        //    for (int i = 1; i < 100; i++)
        //    {
                
                
        //    }
        //}

        //private void DeleteOrderB_Click(object sender, EventArgs e)
        //{
        //    ChosenPlays basket = new ChosenPlays();
            
        //    basket.RemoveFromBasket(OrderBox.Text);
        //    MessageBox.Show("Removed item from basket");
        //    Listl.Text = "";
        //    OrderBox.Items.Clear();
        //    OrderBox.Text = "";
        //    updateScreen();
        //}

        //private void Confirmb_Click(object sender, EventArgs e)
        //{
        //    /*ChosenPlays basket = new ChosenPlays();
            
        //    basket.Checkout(OrderBox.Text);
        //    Listl.Text = "";
        //    OrderBox.Items.Clear();
        //    OrderBox.Text = "";
        //    updateScreen();*/

        //    panel1.Visible = true;

        //    DeleteOrderB.Visible = false;
        //    Confirmb.Visible = false;
        //    Listl.Visible = false;
        //    OrderBox.Visible = false;
        //    ChosenPlays basket = new ChosenPlays();

        //   ConfirmDetailsl.Text = basket.Order(OrderBox.Text,Account.LoginUsername);
        //    if(basket.quantity > 20)
        //    {
        //        discountValue = discountValue - 0.05f;
        //    }
        //   FinalPricel.Text = "Final Price =  £" + (basket.checkValue*discountValue);
        //    checkdouble = basket.checkValue;

        //}

        //private void InputDiscountb_Click(object sender, EventArgs e)

        //{
            

        //    if (DiscountBox.Text == "Discount" && discount1 == false)
        //    {
                
        //        discountValue = discountValue - 0.1f;
        //        if (checkdouble * discountValue < 4)
        //        {
        //            FinalPricel.Text = "Final Price =  £10";
        //            discount1 = true;
        //        }
        //        else
        //        {
        //            FinalPricel.Text = "Final Price =  £" + (checkdouble * discountValue);
        //            discount1 = true;
        //        }
        //    }

        //    if (DiscountBox.Text == "Discount" && discount1 == true)
        //    {
        //        MessageBox.Show ("Code Applied");
        //    }





        //        if (DiscountBox.Text == "1" && discount2 == false)
        //    {

        //        discountValue = discountValue - 0.2f;
        //        if (checkdouble * discountValue < 4)
        //        {
        //            FinalPricel.Text = "Final Price =  £4";
        //            discount2 = true;
        //        }
        //        else
        //        {
        //            FinalPricel.Text = "Final Price =  £" + (checkdouble * discountValue);
        //            discount2 = true;
        //        }
        //    }
        //    if (DiscountBox.Text == "1" && discount2 == true)
        //    {
        //        MessageBox.Show("Code Applied");
        //    }


        //    if (DiscountBox.Text == "2" && discount3 == false)
        //    {

        //        discountValue = discountValue -  0.3f;
        //        if (checkdouble * discountValue < 4)
        //        {
        //            FinalPricel.Text = "Final Price =  £4";
        //            discount3 = true;
        //        }
        //        else
        //        {
        //            FinalPricel.Text = "Final Price =  £" + (checkdouble * discountValue);
        //            discount3 = true;
        //        }

        //    }



        //    if (DiscountBox.Text == "2" && discount3 == true)
        //    {
        //        MessageBox.Show("Code Applied");
        //    }
        //}

        /*private void button1_Click(object sender, EventArgs e)
        {
            ChosenPlays basket = new ChosenPlays();
            //MessageBox.Show(basket.checkEmail(Account.LoginUsername));
            basket.Checkout(OrderBox.Text, (checkdouble*discountValue));
            MessageBox.Show("Play Booked");
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
        */
        //private void Backb_Click(object sender, EventArgs e)
        //{
        //    panel1.Visible = false;
        //    DeleteOrderB.Visible = true;
        //    Confirmb.Visible = true;
        //    Listl.Visible = true;
        //    OrderBox.Visible = true;
        

       
    }
}

