using System.Data.Entity;

namespace callforit_adn.Models
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}