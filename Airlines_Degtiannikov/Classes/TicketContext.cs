using Airlines_Degtiannikov.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Airlines_Degtiannikov.Classes
{
    public class TicketContext: Ticket
    {
        public TicketContext(int Price,string From, string To,DateTime StartTime,DateTime EndTime) : base(Price,From,To,StartTime,EndTime) { }
        public static List<TicketContext> AllTickets()
        {
            List<TicketContext> allTickets = new List<TicketContext>();
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;database=airlines;uid=root;");
            connection.Open();
            MySqlDataReader ticketQuery = WorkingDB.Connection.Query("SELECT * FROM `airlines`.`new_table`;", connection);
            while (ticketQuery.Read())
            {
                allTickets.Add(new TicketContext(
                    ticketQuery.GetInt32(3),
                    ticketQuery.GetString(1),
                    ticketQuery.GetString(2),
                    ticketQuery.GetDateTime(4),
                    ticketQuery.GetDateTime(5)
                    ));
            }
           WorkingDB.Connection.CloseConnection(connection);
            return allTickets;
        }
    }
}
