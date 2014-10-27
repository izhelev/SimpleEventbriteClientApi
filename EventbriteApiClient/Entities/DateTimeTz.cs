using System;

namespace EventbriteApiClient.Entities
{
    public class DateTimeTz
    {
        public string Timezone { get; set; }
        public DateTime Utc { get; set; }
        public DateTime Local { get; set; }
    }
}