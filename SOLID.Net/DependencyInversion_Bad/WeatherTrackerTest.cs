using System;
using System.IO;
using Xunit;

namespace SOLID.Net.DependencyInversion_Bad
{
    public class WeatherTrackerTest
    {
        [Fact]
        public void testReturnsCurrentWeather() {
            StreamWriter sw = new StreamWriter(new FileStream("tmp.txt", FileMode.Create));
            Console.SetOut(sw);

            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("rainy");

            sw.Flush();
            sw.Close();

            Assert.Equal("rainy", tracker.currentConditions);
        }

        [Fact]
        public void testAlertsPhoneUsersWhenRaining() {
            StreamWriter sw = new StreamWriter(new FileStream("tmp.txt", FileMode.Create));
            Console.SetOut(sw);

            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("rainy");

            sw.Flush();
            sw.Close();

            Assert.Equal("It is rainy\n", File.ReadAllText("tmp.txt"));
        }

        [Fact]
        public void testAlertsViaEmailWhenSunny() {
            StreamWriter sw = new StreamWriter(new FileStream("tmp.txt", FileMode.Create));
            Console.SetOut(sw);

            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("sunny");

            sw.Flush();
            sw.Close();

            Assert.Equal("It is sunny\n", File.ReadAllText("tmp.txt"));
        }

    }
}