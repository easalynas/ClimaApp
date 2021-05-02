using ClimApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;


namespace ClimApp.Shared
{
    public static class RestHelper
    {

        private static readonly string baseURL = "https://api.openweathermap.org/data/2.5/weather";

        //Prueba
        public static async Task<string> GetAll()
        {

            using (HttpClient client = new HttpClient())
            {
                    using (HttpResponseMessage res = await client.GetAsync(baseURL + "?q=Lima"+"&APPID=7beb0d073a39a77b46083b172446510c"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }


        //Formato JSON
        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        //Consulta por Ciudad
        public static async Task<string> Get(string temp)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "?q="+ temp + "&APPID=7beb0d073a39a77b46083b172446510c"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
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
