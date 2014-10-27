using System.Collections.Generic;
using EventbriteApiClient.Entities;

namespace EventbriteApiClient.DTOs
{
    public class EventSearchResponse
    {
        public List<Event> Events { get; set; }
    }
}
