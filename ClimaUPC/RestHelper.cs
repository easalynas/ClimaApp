using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClimaUPC
{
    public static class RestHelper
    {

        private static readonly string baseURL = "https://api.openweathermap.org/data/2.5/weather";

        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using(HttpResponseMessage res=await client.GetAsync(baseURL+"?q=Londres"+"&APPID=7beb0d073a39a77b46083b172446510c"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if(data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

    }
}
