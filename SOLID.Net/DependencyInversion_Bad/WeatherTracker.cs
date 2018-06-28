using System;

namespace SOLID.Net.DependencyInversion_Bad
{
    public class WeatherTracker
    {
        public String currentConditions;
        Phone phone;
        Emailer emailer;

        public WeatherTracker() {
            phone = new Phone();
            emailer = new Emailer();
        }

        public void setCurrentConditions(String weatherDescription) {
            this.currentConditions = weatherDescription;
            if (weatherDescription == "rainy") {
                String alert = phone.generateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }
            if (weatherDescription == "sunny") {
                String alert = emailer.generateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }
        }

    }
}