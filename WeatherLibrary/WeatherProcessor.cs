using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherLibrary
{
    public static class WeatherProcessor
    {
        public static async Task<WeatherResultModel> LoadWeatherInfoAsync(string city)
        {
            string url = $"data/2.5/weather?q={city}&units=metric&appid=insertyourappid";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherResultModel result = await response.Content.ReadAsAsync<WeatherResultModel>();

                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
