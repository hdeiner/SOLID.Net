﻿using System;

namespace SOLID.Net.DependencyInversion_Bad
{
    public class Phone
    {
        public String generateWeatherAlert(String weatherConditions) {
            String alert = "It is " + weatherConditions;
            return alert;
        }

    }
}