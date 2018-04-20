using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime DateRedeemed { get; set; }

        public int TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }

        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
