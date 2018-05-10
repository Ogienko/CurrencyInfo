using Newtonsoft.Json;

namespace CurrencyInfo.Models
{
    public class Price
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }
    }
}