using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClimApp.Models
{
    [DataContract]
    internal class Temper
    {
        [DataMember]
        internal double tempera { get; set; }

    
    }
}
