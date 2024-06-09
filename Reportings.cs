using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Cab_Booking_Application
{
    public class Reports
    {
        // Properties for Order details
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }

        // Properties for Customer details
        public string RegNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string IdNumber { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public decimal Total_Amount { get; set; }

        // Constructor for Order details
        public Reports(string id, DateTime orderDate, decimal amount)
        {
            Id = id;
            OrderDate = orderDate;
            Amount = amount;
        }

        // Constructor for Customer details
        public Reports(string regNo, string firstName, string lastName, string email, DateTime dob, string idNumber, string address, string contactNumber,decimal total_amount)
        {
            RegNo = regNo;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DOB = dob;
            IdNumber = idNumber;
            Address = address;
            ContactNumber = contactNumber;
            Total_Amount = total_amount;
        }

        public static List<Reports> GetOrders(string refNumber)
        {
            List<Reports> orders = new List<Reports>();

            using (SqlConnection conn = DBconnection.ConnectToDB())
            {
                string orderQuery = "SELECT refno, date, amt FROM Trn_mas WHERE (refno = @vehNo OR @vehNo IS NULL)";
                SqlCommand command = new SqlCommand(orderQuery, conn);
                if (string.IsNullOrEmpty(refNumber))
                {
                    command.Parameters.AddWithValue("@vehNo", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@vehNo", refNumber);
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["refno"].ToString();
                        DateTime orderDate = Convert.ToDateTime(reader["date"]);
                        decimal amount = Convert.ToDecimal(reader["amt"]);
                        orders.Add(new Reports(id, orderDate, amount));
                    }
                }
            }
            return orders;
        }

        public static List<Reports> DisplayCustomerDetails(string custNumber)
        {
            List<Reports> customerDetails = new List<Reports>();

            using (SqlConnection conn = DBconnection.ConnectToDB())
            {
                string customerQuery = "SELECT Customer.RegNo, F_Name, L_Name, Email, DOB, id_no, address, Contectno, SUM(trn_mas.amt) AS TotalAmount FROM Customer LEFT JOIN Trn_mas ON Trn_mas.Cust_Id = Customer.RegNo WHERE Customer.RegNo = @custNo GROUP BY Customer.RegNo, F_Name, L_Name, Email, DOB, id_no, address, Contectno";
                SqlCommand command = new SqlCommand(customerQuery, conn);
                command.Parameters.AddWithValue("@custNo", custNumber);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string regNo = reader["RegNo"].ToString();
                        string firstName = reader["F_Name"].ToString();
                        string lastName = reader["L_Name"].ToString();
                        string email = reader["Email"].ToString();
                        DateTime dob = Convert.ToDateTime(reader["DOB"]);
                        string idNumber = reader["id_no"].ToString();
                        string address = reader["address"].ToString();
                        string contactNumber = reader["Contectno"].ToString();
                        decimal totalAmount = reader["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(reader["TotalAmount"]) : 0m;

                       
                        // Populate customer details
                        Reports customer = new Reports(regNo, firstName, lastName, email, dob, idNumber, address, contactNumber, totalAmount);
                        customerDetails.Add(customer);
                    }
                }
            }

            return customerDetails;
        }

    }
}
