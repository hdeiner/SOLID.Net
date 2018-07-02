using System;
using System.Collections.Generic;

namespace SOLID.Net.DependencyInversion_Good
{
    public class MobileDevice : Notifier
    {
        private List<String> consoleOutput;

        public MobileDevice()
        {
            consoleOutput = new List<string>();    
        }

        public void alertWeatherConditions(String weatherConditions) {
            if (weatherConditions == "rainy")
                consoleOutput.Add("It is rainy");
        }
        
        public String getConsoleOutput()
        {
            return String.Join("\n", consoleOutput);
        }

    }
}