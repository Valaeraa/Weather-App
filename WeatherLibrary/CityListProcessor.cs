using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherLibrary
{
    public static class CityListProcessor
    {
        public static List<CityListModel> LoadCityNameList(string fileName)
        {
            var cities = new List<CityListModel>();
            var serializer = new JsonSerializer();

            using (var reader = new StreamReader(fileName))
            using (var jsonReader = new JsonTextReader(reader))
            {
                cities = serializer.Deserialize<List<CityListModel>>(jsonReader);
            }

            return cities;
        }
    }
}
