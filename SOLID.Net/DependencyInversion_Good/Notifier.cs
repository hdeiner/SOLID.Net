using System;
using System.Collections.Generic;

namespace SOLID.Net.DependencyInversion_Good
{
    public interface Notifier
    {
        void alertWeatherConditions(String weatherConditions);
    }
}