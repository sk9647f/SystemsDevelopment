using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBookingSystem
{
    class Discounts
    {
        string ticketType; //checks ticket type in order
        string seatingBand;
        string nameOfPlay;
        DateTime dateOfPlay;
        int timeOfPlay;
        double total;
        int ticketQuantity;
        double newTotal;


        public void DisplayTicket()
        {

        }

        //If you buy 4 tickets you get 1 free
        public void BuyFourGetOneFree()
        {
            if (ticketQuantity == 4)
            {
                newTotal = total * ticketQuantity + 1;
            }
        }

        // If more than 20 people 10% discount, if less 5% discount
        public void AgencyDiscounts()
        {
            if (ticketQuantity >= 20)
            {
                newTotal = total * (0.90);
            }
            else
            {
                newTotal = total * (0.95);
            }
        }

        //10% discount Mon-Thu
        public void MondayToThusday()
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            
            if (today == DayOfWeek.Monday)
            {
                newTotal = total * (0.90);
            }

            if (today == DayOfWeek.Tuesday)
            {
                newTotal = total * (0.90);
            }

            if (today == DayOfWeek.Wednesday)
            {
                newTotal = total * (0.90);
            }

            if (today == DayOfWeek.Thursday)
            {
                newTotal = total * (0.90);
            }
        }





    }
}
