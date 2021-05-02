using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace ClimApp.Models
{
    // NOTA: Intento fallido
    public class Tempe 
    {
        internal double tempera { get; set; }

        internal Tempe ToString(Formatting indented)
        {
            throw new NotImplementedException();
        }
    }
}
