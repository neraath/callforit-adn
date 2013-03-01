using System.Collections.Generic;

namespace callforit_adn.Models
{
    public class EventRepository : IEventRepository
    {
        private EventContext eventContext;

        public EventRepository(EventContext context)
        {
            eventContext = context;
        }

        public IEnumerable<Event> Events
        {
            get { return eventContext.Events; }
        }
    }
}