using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Forms;

namespace ClimaUPC
{
    public class RestService
    {

        HttpClient _client;
        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<PostViewModel> GetWeatherDataAsync(string uri)
        {
            PostViewModel weatherData = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<PostViewModel>(content);
                    
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return weatherData;
        }


    }
}
