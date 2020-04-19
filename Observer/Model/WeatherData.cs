using System;
using System.Collections;
using Observer.Interface;

namespace Observer.Model
{
    public class WeatherData: ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            this.observers = new ArrayList();
        }
        
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            int index = observers.IndexOf(observer);

            if (index >= 0) {
                observers.RemoveAt(index);
            }
            Console.WriteLine('1');
        }
        
        public void NotifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                var observer = (IObserver)observers[i];
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged() 
        {
            NotifyObserver();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}