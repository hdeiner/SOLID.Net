using System;

namespace SOLID.Net.DependencyInversion_Good
{
    public class EmailClient : Notifier
    {
        public void alertWeatherConditions(String weatherConditions) {
            if (weatherConditions == "sunny") { 
                Console.WriteLine("It is sunny");
            }
        }
   
    }
}