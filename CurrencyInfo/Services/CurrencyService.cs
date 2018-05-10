using CurrencyInfo.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace CurrencyInfo.Services
{
    public class CurrencyService
    {
        private static readonly string Url = "http://phisix-api3.appspot.com/stocks.json";

        public static Stock GetStock()
        {
            var client = new HttpClient();
            var result = client.GetStringAsync(Url).Result;
            return JsonConvert.DeserializeObject<Stock>(result);
        }
    }
}