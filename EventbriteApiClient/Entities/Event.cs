using RestSharp.Deserializers;

namespace EventbriteApiClient.Entities
{
    public class Event
    {
        [DeserializeAs(Name = "resource_uri")]
        public string ResourceUri { get; set; }
        public MultipartText Name { get; set; }
        public string Url { get;set; }
        [DeserializeAs(Name = "logo_url")]
        public string LogoUrl { get; set; }
        public DateTimeTz Start { get; set; }
        public DateTimeTz End { get; set; }
       
    }
}
