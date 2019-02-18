using EventManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Service
{
    public interface IEventService
    {
        List<Event_Domain> GetEventsUsingLINQ();
    }
}
