using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherLibrary
{
    public class WeatherResultModel
    {
        [JsonProperty(PropertyName = "main")]
        public WeatherModel MainWeather { get; set; }

        [JsonProperty(PropertyName = "coord")]
        public Coord Coord { get; set; }

        [JsonProperty(PropertyName = "weather")]
        public List<Weather> WeatherInfo { get; set; }

        [JsonProperty(PropertyName = "visibility")]
        public int Visibility { get; set; }

        [JsonProperty(PropertyName = "wind")]
        public Wind Wind { get; set; }

        [JsonProperty(PropertyName = "clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty(PropertyName = "dt")]
        public int DateTime { get; set; }

        [JsonProperty(PropertyName = "sys")]
        public Sys Sys { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string CityName { get; set; }
    }
}
