using Airlines_Degtiannikov.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Documents;

namespace Airlines_Degtiannikov.Classes
{
    public class TicketContext: Ticket
    {
        public static List<TicketContext> AllTicket()
        {
            List<TicketContext> allTickets = new List<TicketContext>();
        
            return allTickets;
        }
    }
}
