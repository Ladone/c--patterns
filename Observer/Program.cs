using System;
using Observer.Model;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer started v1.0!");
            Console.WriteLine("Created by @echoladone");
            
            var weatherData    = new WeatherData();
            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            
            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.8f);
            weatherData.setMeasurements(78, 90, 29.2f);
        }
    }
}