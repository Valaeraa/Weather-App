using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherLibrary
{
    public class CityListModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
