﻿using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Cab_Booking_Application
{
    public class Email
    {
        SqlConnection conn;

        public string Id { get; set; }
        public string Cust_Name { get; set; }
        public string Date { get; set; }
        public string Order_Id { get; set; }
        public string Cost { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string From_Loc { get; set; }
        public string To_Loc { get; set; }
        public string Veh_ID { get; set; }

        public Email(string id, string cust_Name, string date, string order_Id, string cost, string start_Date, string end_Date, string from_Loc, string to_Loc, string veh_ID)
        {
            Id = id;
            Cust_Name = cust_Name;
            Date = date;
            Order_Id = order_Id;
            Cost = cost;
            Start_Date = start_Date;
            End_Date = end_Date;
            From_Loc = from_Loc;
            To_Loc = to_Loc;
            Veh_ID = veh_ID;
            conn = DBconnection.ConnectToDB();
        }

        public string GenerateInvoiceHtml()
        {
            string htmlTemplate = @"
                <html>
                <head>
                    <style>
                        body { font-family: Arial, sans-serif; }
                        .invoice-box {
                            max-width: 800px;
                            margin: auto;
                            padding: 30px;
                            border: 1px solid #eee;
                            box-shadow: 0 0 10px rgba(0, 0, 0, 0.15);
                            font-size: 16px;
                            line-height: 24px;
                            color: #555;
                        }
                        .invoice-box table {
                            width: 100%;
                            line-height: inherit;
                            text-align: left;
                            border-collapse: collapse;
                        }
                        .invoice-box table td {
                            padding: 5px;
                            vertical-align: top;
                        }
                        .invoice-box table tr td:nth-child(2) {
                            text-align: right;
                        }
                        .invoice-box table tr.top table td {
                            padding-bottom: 20px;
                        }
                        .invoice-box table tr.top table td.title {
                            font-size: 45px;
                            line-height: 45px;
                            color: #333;
                        }
                        .invoice-box table tr.information table td {
                            padding-bottom: 40px;
                        }
                        .invoice-box table tr.heading td {
                            background: #eee;
                            border-bottom: 1px solid #ddd;
                            font-weight: bold;
                        }
                        .invoice-box table tr.details td {
                            padding-bottom: 20px;
                        }
                        .invoice-box table tr.item td {
                            border-bottom: 1px solid #eee;
                        }
                        .invoice-box table tr.item.last td {
                            border-bottom: none;
                        }
                        .invoice-box table tr.total td:nth-child(2) {
                            border-top: 2px solid #eee;
                            font-weight: bold;
                        }
                    </style>
                </head>
                <body>
                    <div class='invoice-box'>
                        <table>
                            <tr class='top'>
                                <td colspan='2'>
                                    <table>
                                        <tr>
                                            <td class='title'>
                                                <h2>Invoice</h2>
                                            </td>
                                            <td>
                                                Order ID: {0}<br>
                                                Date: {1}
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr class='information'>
                                <td colspan='2'>
                                    <table>
                                        <tr>
                                            <td>
                                                <b>From:</b><br>
                                                Cab Booking Application<br>
                                                Company Address
                                            </td>
                                            <td>
                                                <b>To:</b><br>
                                                {2}<br>
                                                Customer ID: {11}
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr class='heading'>
                                <td>
                                    Payment Method
                                </td>
                                <td>
                                    Amount #
                                </td>
                            </tr>
                            <tr class='details'>
                                <td>
                                    Credit Card
                                </td>
                                <td>
                                    {3}
                                </td>
                            </tr>
                            <tr class='heading'>
                                <td>
                                    Item
                                </td>
                                <td>
                                    Price
                                </td>
                            </tr>
                            <tr class='item'>
                                <td>
                                    Vehicle ID: {4}
                                </td>
                                <td>
                                    {3}
                                </td>
                            </tr>
                            <tr class='item'>
                                <td>
                                    From: {5} To: {6}
                                </td>
                                <td>
                                    Duration: {7} to {8}
                                </td>
                            </tr>
                            <tr class='item'>
                                <td>
                                    From Location: {9}
                                </td>
                                <td>
                                    To Location: {10}
                                </td>
                            </tr>
                            <tr class='total'>
                                <td></td>
                                <td>
                                   Total: {3}
                                </td>
                            </tr>
                        </table>
                    </div>
                </body>
                </html>";

            return string.Format(htmlTemplate, Order_Id, Date, Cust_Name, Cost, Veh_ID, From_Loc, To_Loc, Start_Date, End_Date, From_Loc, To_Loc, Id);
        }

        public void SendEmailToCustomer()
        {
            try
            {
                SmtpClient mySmtpClient = new SmtpClient("mail.gosmart.lk");

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = false;
                NetworkCredential basicAuthenticationInfo = new NetworkCredential("hakeemfareed@gosmart.lk", "KAb$KVX.%3Wy");
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from, to mailaddresses
                MailAddress from = new MailAddress("hakeemfareed@gosmart.lk", "TestFromName");
                MailAddress to = new MailAddress("hakeemfareed01@gmail.com", "Customer");
                MailMessage myMail = new MailMessage(from, to);

                // add ReplyTo
                MailAddress replyTo = new MailAddress("auto@gosmart.lk");
                myMail.ReplyToList.Add(replyTo);

                myMail.Subject = "Your Invoice";
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;
                myMail.Body = GenerateInvoiceHtml();
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }
            catch (SmtpException ex)
            {
                throw new ApplicationException("SmtpException has occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}