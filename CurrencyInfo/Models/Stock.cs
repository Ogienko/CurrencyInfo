using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CurrencyInfo.Models
{
    public class Stock
    {
        [JsonProperty("stock")]
        public List<Currency> Currencies { get; set; }

        [JsonProperty("as_of")]
        public DateTime AsOf { get; set; }
    }
}