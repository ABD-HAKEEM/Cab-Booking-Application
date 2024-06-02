using System;
using System.Collections.Generic;

namespace Cab_Booking_Application
{
    public class Order
    {
        public string Order_ID { get; private set; }
        public string Date { get; set; }

        public static Random random = new Random();
        public static HashSet<int> generatedNumbers = new HashSet<int>();

        public Order(string date,string orderid)
        {
            Order_ID = orderid;
            Date = date;
            
        }

        public void Autogen()
        {
            int number;
            do
            {
                number = random.Next(100000, 999999);
            } while (generatedNumbers.Contains(number));

            generatedNumbers.Add(number);
            Order_ID = "CB" + number.ToString();
           
        }
    }
}
