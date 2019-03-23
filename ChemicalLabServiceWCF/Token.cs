using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ChemicalLabServiceWCF
{
    public class Token
    {
        [JsonProperty("token")]
        public string token { get; set; }
        [JsonProperty("privatetoken")]
        public object privatetoken { get; set; }
    }
}