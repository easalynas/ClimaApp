using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClimApp.Models
{

    //Intento fallido
    public class WeatherData
    {


        [JsonProperty("main")]

        public Main main { get; set; }

 


    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

    }
  


}
