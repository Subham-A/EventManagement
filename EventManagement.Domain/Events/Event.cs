using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Domain
{
    public class Event_Domain
    {
       
        public decimal EventId { get; set; }
        public string EventName { get; set; }
        public int EventPrice { get; set; }
        public string Location { get; set; }
        public int TicketPrice { get; set; }
        public decimal CategoryId { get; set; }
        public DateTime Date { get; set; }

    }
}
