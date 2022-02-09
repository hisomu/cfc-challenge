using Newtonsoft.Json;

namespace CountryService.Models
{
    public class City
    {
        public string Municipality { get; set; }

        public string Province { get; set; }

        [JsonProperty("Municipal status")]
        public string MunicipalStatus { get; set; }

        [JsonProperty("Land area(km2, 2011)")]
        public string LandAreaKm22011 { get; set; }

        [JsonProperty("Population(2016)")]
        public string Population2016 { get; set; }

        [JsonProperty("Population(2011)")]
        public string Population2011 { get; set; }

        [JsonProperty("Population(2006)")]
        public string Population2006 { get; set; }

        [JsonProperty("Population(2001)")]
        public string Population2001 { get; set; }

        [JsonProperty("Population(1996)")]
        public string Population1996 { get; set; }
    }
}
