using System;

namespace SOLID.Net.DependencyInversion_Good
{
    public class MobileDevice : Notifier
    {
        public void alertWeatherConditions(String weatherConditions) {
            if (weatherConditions == "rainy")
                Console.WriteLine("It is rainy");
        }

    }
}