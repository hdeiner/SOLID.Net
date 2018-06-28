using System;

namespace SOLID.Net.DependencyInversion_Good
{
    public class WeatherTracker
    {
        public String currentConditions;

        public void setCurrentConditions(String weatherDescription) {
            this.currentConditions = weatherDescription;
        }

        public void notify(Notifier notifier) {
            notifier.alertWeatherConditions(currentConditions);
        }

    }
}