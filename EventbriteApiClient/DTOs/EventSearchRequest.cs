using System;
using RestSharp;

namespace EventbriteApiClient.DTOs
{
    public class EventSearchRequest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime DateRangeStart { get; set; }
        public DateTime DateRangeEnd { get; set; }
        /// <summary>
        /// This should be interger followed by mi or km
        /// </summary>
        public string Range { get; set; } 

        public RestRequest ToRequest()
        {
            var request = new RestRequest("/events/search/?token={token}", Method.GET);
            request.AddParameter("location.latitude", this.Latitude.ToString());
            request.AddParameter("location.longitude", this.Longitude.ToString());
            request.AddParameter("location.within", this.Range);
            if (this.DateRangeStart != DateTime.MinValue)
            {
                request.AddParameter("start_date.range_start", this.DateRangeStart.ToUniversalTime()
                    .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'"));
            }
            if (this.DateRangeEnd != DateTime.MinValue)
            {
                request.AddParameter("start_date.range_end", this.DateRangeEnd.ToUniversalTime()
                    .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'"));
            }

            return request;
        }
    }
}
