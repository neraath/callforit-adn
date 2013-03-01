using System.Data.Entity;

namespace callforit_adn.Models
{
    public class EventContext : DbContext
    {
        public EventContext() : base("callforit")
        {
        }
        public DbSet<Event> Events { get; set; }
    }
}