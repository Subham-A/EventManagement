using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Repository
{
    public class EventsDB
    {

        public List<Event> GetEventsUsingLINQ() {
            List<Event> evt = null;
            using (var context = new EventManagementEntities()) {

                evt = context.Events.Where(ev => ev.TicketPrice > 50).ToList();
            }

            return evt;
        }
    }
}
