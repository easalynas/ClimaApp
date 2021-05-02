using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClimApp.Models
{

    //INTENTO FALLIDO
    public class TemperaturaCiudad
    {
        [JsonProperty("main")]

        public Main main { get; set; }

    }

}
