using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;

namespace ApiConsumerLibrary
{
    public class ApiConsumer
    {
        private readonly HttpClient _client;
       // public static string ApiKey { get; set; }

        public ApiConsumer()
        {
            _client = new HttpClient();
          //  ApiKey = "ks26-coe2-424k-57ry";
        }

        // public async Task<double> GetDolarValueAsync(DateTime date)

        // public async Task<string> GetDollarRate(DateTime? date = null)
        public static string GetDollarRate(DateTime date)
        {
            string dateString = date.ToString("yyyy-MM-dd") ?? string.Empty;
            string url = $"https://apps.webs.hn/dolar/api/?key=ks26-coe2-424k-57ry&date={dateString}";

            using (var client = new System.Net.WebClient())
            {
                string result = client.DownloadString(url);

                return result;
            }
        }
    }
}
