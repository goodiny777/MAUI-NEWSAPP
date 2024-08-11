using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=71fcafbb8e80aa02b576b9e88acbfceb&lang=en&topic=" + categoryName.ToLower());
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
