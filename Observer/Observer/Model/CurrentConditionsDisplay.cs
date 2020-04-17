using System;
using Observer.Interface;

namespace Observer.Model
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }
        
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine(@"Current conditions: {0}F degrees and {1}% humidity", temperature, humidity);
        }
    }
}