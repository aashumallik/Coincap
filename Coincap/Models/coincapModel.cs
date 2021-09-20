using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coincap.Models
{   //to create the model use json to c# formatter online
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Datum
    {
        public string id { get; set; }
        public string rank { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string supply { get; set; }

        
    }

    public class coincapModel
    {
        public List<Datum> data { get; set; }
        public long timestamp { get; set; }
    }
}