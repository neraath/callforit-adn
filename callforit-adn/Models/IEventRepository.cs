using System;
using System.Collections.Generic;

namespace callforit_adn.Models
{
    public interface IEventRepository
    {
        IEnumerable<Event> Events { get; }
    }
}
