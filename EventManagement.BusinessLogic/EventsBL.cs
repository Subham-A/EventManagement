using EventManagement.Domain;
using EventManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.BusinessLogic
{
    public class EventsBL
    {

        public List<Event_Domain> GetEventsUsingLINQ() {
            var dbInstance = new EventsDB();

            var details = dbInstance.GetEventsUsingLINQ();

            List<Event_Domain> domainEnts = new List<Event_Domain>();

            if (details != null && details.Any()) {
                details.ForEach(ev => {

                    domainEnts.Add(new Event_Domain {

                        CategoryId = ev.CategoryId,
                        Date = ev.Date,
                        EventId = ev.EventId,
                        EventName = ev.EventName,
                        EventPrice = ev.EventPrice,
                        Location = ev.Location,
                        TicketPrice = ev.TicketPrice
                    });
                });
            }

            return domainEnts;
        }
    }
}
