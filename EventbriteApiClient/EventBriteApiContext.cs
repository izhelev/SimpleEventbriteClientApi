using System.Collections.Generic;
using EventbriteApiClient.DTOs;
using EventbriteApiClient.Entities;

namespace EventbriteApiClient
{
    public class EventBriteApiContext
    {
        private readonly EventbriteApiBase _api;

        public EventBriteApiContext(string oauthKey)
        {
            _api = new EventbriteApiBase(oauthKey);
        }

        public IEnumerable<Event> GetEvents(EventSearchRequest request)
        {           
            var response = _api.Execute<EventSearchResponse>(request.ToRequest());

            if (response.Events != null)
            {
                return response.Events;
            }

            return new List<Event>();

        }
    }
}
