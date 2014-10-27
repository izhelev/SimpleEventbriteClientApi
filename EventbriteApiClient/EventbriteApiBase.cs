using System;
using RestSharp;

namespace EventbriteApiClient
{
    public class EventbriteApiBase
    {
        private readonly string _oauthToken;
        private const string BaseUrl = "https://www.eventbriteapi.com/v3";

        public EventbriteApiBase(string oauthToken)
        {
            _oauthToken = oauthToken;
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = BaseUrl;
            request.AddUrlSegment("token", _oauthToken); 

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var twilioException = new ApplicationException(message, response.ErrorException);
                throw twilioException;
            }
            return response.Data;
        }
    }
}
