using System;
using System.Collections.Generic;

namespace SOLID.Net.DependencyInversion_Bad
{
    public class WeatherTracker
    {
        public String currentConditions;
        Phone phone;
        Emailer emailer;
        private List<String> consoleOutput;

        public WeatherTracker() {
            phone = new Phone();
            emailer = new Emailer();
            consoleOutput = new List<string>();
        }

        public void setCurrentConditions(String weatherDescription) {
            this.currentConditions = weatherDescription;
            if (weatherDescription == "rainy") {
                String alert = phone.generateWeatherAlert(weatherDescription);
                consoleOutput.Add(alert);
            }
            if (weatherDescription == "sunny") {
                String alert = emailer.generateWeatherAlert(weatherDescription);
                consoleOutput.Add(alert);
            }
        }

        public String getConsoleOutput()
        {
            return String.Join("\n", consoleOutput);
        }

    }
}