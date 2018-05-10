using Newtonsoft.Json;

namespace CurrencyInfo.Models
{
    public class Currency
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("percent_change")]
        public double PercentChange { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}