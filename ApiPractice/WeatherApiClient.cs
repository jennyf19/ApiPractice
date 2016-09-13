using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ApiPractice
{
    public static class WeatherApiClient
    {
        public static void GetWeatherForecast()
        {
            var url = "https://api.github.com/users/defunkt";
                //http://api.openweathermap.org/data/2.1/find/city?lat=51.50853&1on=-0.12574&cnt=10
            //Snycronious Consumption
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);
        }
    }
}
