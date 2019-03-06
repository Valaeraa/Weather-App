using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherLibrary
{
    public class WeatherModel
    {
        [JsonProperty(PropertyName = "temp")]
        public float Temperature { get; set; }

        [JsonProperty(PropertyName = "temp_min")]
        public int MinTemp { get; set; }

        [JsonProperty(PropertyName = "temp_max")]
        public int MaxTemp { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public float Pressure { get; set; }

        [JsonProperty(PropertyName = "sea_level")]
        public float SeaLevel { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public int Humidity { get; set; }
    }

    public class Coord
    {
        [JsonProperty(PropertyName = "lon")]
        public float Lon { get; set; }

        [JsonProperty(PropertyName = "lat")]
        public float Lat { get; set; }
    }

    public class Wind
    {
        [JsonProperty(PropertyName = "speed")]
        public double Speed { get; set; }

        [JsonProperty(PropertyName = "deg")]
        public double Deg { get; set; }
    }

    public class Rain
    {
        public float _3h { get; set; }

    }

    public class Clouds
    {
        [JsonProperty(PropertyName = "all")]
        public int All { get; set; }
    }

    public class Sys
    {
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "message")]
        public float Message { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty(PropertyName = "sunset")]
        public int Sunset { get; set; }
    }

    public class Weather
    {
        [JsonProperty(PropertyName = "id")]
        public int ID { get; set; }

        [JsonProperty(PropertyName = "main")]
        public string Main { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }
    }
}
