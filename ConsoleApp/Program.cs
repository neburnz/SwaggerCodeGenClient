using System;
using WebApi.Api;
using WebApi.Client;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Invocar API a traves de Client
            // BasePath: http://localhost:5000
            IWeatherForecastApi api = new WeatherForecastApi("http://localhost:5000");
            var response = api.WeatherForecastGet();
            foreach(var item in response)
            {
                Console.WriteLine($"{item.Date} {item.TemperatureC} {item.TemperatureF} {item.Summary}");
            }
        }
    }
}
