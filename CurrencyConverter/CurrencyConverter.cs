using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace CurrencyConverter
{
    public class CurrencyConverter
    {
        Dictionary<string, string> currencySymbols;

        public Dictionary<string, string> GetCurrencySymbols()
        {
            // creates new Dictionary data type object with values string, string (key, value) store in dictionary object currencySymbols
            // method getResponseString() will call API (responseContent)
            if (currencySymbols == null)
            {
                currencySymbols = new Dictionary<string, string>();
                string responseContent = getResponseString($"exchangerates_data/symbols");

                // Convert string to Json Object--string (Key) object (value)--by passing string value responseContent which 
                // receives its value from getResponseString method
                Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
                if ((bool)responseData["success"])
                {
                    // Variable tempSymbols holds a JObject responseData["symbols"]
                    var tempSymbols = (JObject)responseData["symbols"];
                    currencySymbols = tempSymbols.ToObject<Dictionary<string, string>>();
                }
            }
            return currencySymbols;
        }

        public double Convert(string fromCurrency, string toCurrency, double fromCurrencyAmount)
        {
            string responseContent = getResponseString($"exchangerates_data/convert?to={toCurrency}&from={fromCurrency}&amount={fromCurrencyAmount}");

            Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);

            if ((bool)responseData["success"])
            {
                return (double)responseData["result"];
            }
            else
            {
                return -1;
            }
        }

        private string getResponseString(string correspondingURI)
        {
            // Add reference to API client using base URL
            var client = new RestClient($"https://api.apilayer.com/");
            //client.Timeout = -1;

            // Add request from API using Method.Get
            var request = new RestRequest(correspondingURI, Method.Get);
            request.AddHeader("apikey", "pnwCUeO7LgzUUgU3eX9MbPK12jM0gDpW");

            // Makes call to the API
            RestResponse response = client.Execute(request);
            return response.Content;
            //Console.WriteLine(response.Content);
        }
    }
}
