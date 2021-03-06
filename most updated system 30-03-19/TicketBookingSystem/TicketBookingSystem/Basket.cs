﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TicketBookingSystem
{
    abstract class Basket
    {
        double basketTotal;
        int cost, quantity;
        string play, user;
        DateTime date;
        public abstract void AddToOrder(string user, string play, int cost, int quantity, DateTime date, string ticketType);
        public abstract void AddToBasket(string userID, string PlayChosen, float Standard, float Child, float OAP, DateTime PlayDate, string Time, string Price, float Quantity);
        public abstract void RemoveFromBasket(string OrderID);
    }

    class ChosenPlays : Basket
    {
        public string title;
        public int orderID;
        public string UserID;
        public string Standard;
        public string OAP;
        public string Child;
        public DateTime date;
        public string time;
        public float price;
        public float quantity;

        public string userEmail;
        public int success = 1;
        public double checkValue;
        public override void AddToOrder(string user, string play, int cost, int quantity, DateTime date, string ticketType)
        {
            
        }
        public string Order(string OrderID, string UserID)
        {
            string connString;
            string initialreturn;
            int intreturn;
            string addString = "";
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand ReadCommand = new OleDbCommand("SELECT * FROM Basket WHERE OrderID = @OrderID", myConnection);
            ReadCommand.Parameters.AddWithValue("@OrderID", OrderID);

            OleDbDataReader reader = ReadCommand.ExecuteReader();
            while (reader.Read())
            {
                initialreturn = reader.GetString(2);

                addString += "Title: " + initialreturn + "  ";
                initialreturn = reader.GetDateTime(6).ToShortDateString();
                addString += "Date: " + initialreturn + "  ";
                initialreturn = reader.GetString(7);
                addString += "Time: " + initialreturn + "\n";
                addString += "\n";
                quantity = reader.GetInt32(9);
                addString += "Ticket Quantity = " + quantity;
                addString += "\n";
                initialreturn = reader.GetString(3);
                addString += initialreturn + "  Standard Tickets";
                initialreturn = reader.GetString(4);
                addString += "    " + initialreturn + "  Child Tickets";
                initialreturn = reader.GetString(5);
                addString += "    " + initialreturn + "  OAP Tickets";
                addString += "\n";
                intreturn = reader.GetInt32(8);
                checkValue = intreturn;
                addString += "Current price before discounts = £" + intreturn;


            }
            



            
            


                myConnection.Close();

            

            return addString;

        }

        public string checkEmail(string username)
        {
            string returnoutput = "";
            string connString = "";
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("SELECT * FROM User", myConnection);

            //myCommand.Parameters.AddWithValue("@Username", username);
            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                returnoutput = reader.GetString(0);

            }

            return returnoutput;
        }






        public void Checkout(string OrderID, double finalPrice)
        {
            
            string connString;


            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            myConnection.Open();
            OleDbCommand ReadCommand = new OleDbCommand("SELECT * FROM Basket WHERE OrderID = @OrderID", myConnection);
            ReadCommand.Parameters.AddWithValue("@OrderID", OrderID);

            OleDbDataReader reader = ReadCommand.ExecuteReader();
            while (reader.Read())
            {
                orderID = reader.GetInt32(0);
                UserID = reader.GetString(1);
                title = reader.GetString(2);
                Standard = reader.GetString(3);
                Child = reader.GetString(4);
                OAP = reader.GetString(5);
                date = reader.GetDateTime(6);
                time = reader.GetString(7);
                price = reader.GetInt32(8);
                quantity = reader.GetInt32(9);
                


            }
            myConnection.Close();

            myConnection.Open();
            OleDbCommand myCommand = new OleDbCommand("INSERT INTO OrderHistory (UserID, OrderID, Play, DateOfPlay, TimeOfPlay, Price, Quantity, Standard, Child, OAP) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", myConnection);

            myCommand.Parameters.AddWithValue("@UserID", UserID);
            myCommand.Parameters.AddWithValue("@OrderID", orderID);
            myCommand.Parameters.AddWithValue("@Play", title);
            myCommand.Parameters.AddWithValue("@DateOfPlay", date);
            myCommand.Parameters.AddWithValue("@TimeOfPlay", time);
            myCommand.Parameters.AddWithValue("@Price", finalPrice);
            myCommand.Parameters.AddWithValue("@Quantity", quantity);
            myCommand.Parameters.AddWithValue("@Standard", Standard);
            myCommand.Parameters.AddWithValue("@Child", Child);
            myCommand.Parameters.AddWithValue("@OAP", OAP);

            
            myCommand.ExecuteNonQuery();
            myConnection.Close();


        }

        public void SelectSeats()
        {

        }

        public void ReserveSeats()
        {

        }

        public void AddToBasket()
        {
        }

        public override void RemoveFromBasket(string OrderID)
        {
            string connString;
            connString = @"Provider=Microsoft.JET.OLEDB.4.0;Data Source = L:\Comp-1632-System Development Project\TicketBookingSystem\TicketBookingSystem\TicketSysDB.mdb";

            OleDbConnection myConnection = new OleDbConnection(connString);
            

            OleDbCommand RemoveCommand = new OleDbCommand("DELETE FROM Basket WHERE OrderID = @OrderID", myConnection);
            RemoveCommand.Parameters.AddWithValue("@OrderID", OrderID);
            myConnection.Open();
            RemoveCommand.ExecuteNonQuery();
            myConnection.Close();


        }

        public void ApplyDiscounts()
        {

        }

        public override void AddToBasket(string userID, string PlayChosen, float Standard, float Child, float OAP, DateTime PlayDate, string Time, string Price, float Quantity)
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
    }
}
