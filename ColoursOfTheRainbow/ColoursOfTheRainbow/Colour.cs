using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ColoursOfTheRainbow
{
    public class Colour
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("hex")]
        public string hex { get; set; }
        [JsonProperty("rgba")]
        public string rgba { get; set; }
    }

}
