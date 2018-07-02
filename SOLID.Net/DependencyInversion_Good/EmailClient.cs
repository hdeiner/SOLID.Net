using System;
using System.Collections.Generic;

namespace SOLID.Net.DependencyInversion_Good
{
    public class EmailClient : Notifier
    {
        private List<String> consoleOutput;

        public EmailClient()
        {
            consoleOutput = new List<string>();    
        }
        
        public void alertWeatherConditions(String weatherConditions) {
            if (weatherConditions == "sunny") { 
                consoleOutput.Add("It is sunny");
            }
        }
   
        public String getConsoleOutput()
        {
            return String.Join("\n", consoleOutput);
        }

    }
}