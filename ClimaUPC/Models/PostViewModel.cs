using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ClimaUPC
{
    public class PostViewModel
    {
        
        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }


        [JsonProperty("main")]

        public Main main { get; set; }

        [JsonProperty("Visibility")]
        public long Visibility { get; set; }

       
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("humidity")]
        public long Humiduty { get; set; }
    }
    public class Weather
    {
        [JsonProperty("main")]
        public string Visibility { get; set; }
    }





}

