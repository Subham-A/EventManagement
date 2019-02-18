
using EventManagement.BusinessLogic;
using EventManagement.Domain;
using EventManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Service
{
    public class EventService : IEventService
    {
        public List<Event_Domain> GetEventsUsingLINQ()
        {
            EventsBL logic = new EventsBL();

            return logic.GetEventsUsingLINQ();
        }
    }
}
