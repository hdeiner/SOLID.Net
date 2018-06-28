using System;

namespace SOLID.Net.DependencyInversion_Good
{
    public interface Notifier
    {
        void alertWeatherConditions(String weatherConditions);
  
    }
}