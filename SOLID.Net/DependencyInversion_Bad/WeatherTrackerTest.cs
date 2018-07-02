using System;
using System.Text;
using Xunit;

namespace SOLID.Net.DependencyInversion_Bad
{
    public class WeatherTrackerTest
    {
        [Fact]
        public void testReturnsCurrentWeather() {
            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("rainy");

            Assert.Equal("rainy", tracker.currentConditions);
        }

        [Fact]
        public void testAlertsPhoneUsersWhenRaining() {
            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("rainy");

            Assert.Equal("It is rainy", tracker.getConsoleOutput());
        }

        [Fact]
        public void testAlertsViaEmailWhenSunny() {
            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("sunny");

            Assert.Equal("It is sunny", tracker.getConsoleOutput());
        }

    }
}