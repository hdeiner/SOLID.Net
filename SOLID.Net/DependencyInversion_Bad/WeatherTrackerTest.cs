using System;
using System.Text;
using Xunit;

namespace SOLID.Net.DependencyInversion_Bad
{
    public class WeatherTrackerTest
    {
        [Fact]
        public void testReturnsCurrentWeather() {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
            Console.SetOut(sw);

            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("rainy");

            sw.Flush();

            Assert.Equal("rainy", tracker.currentConditions);
        }

        [Fact]
        public void testAlertsPhoneUsersWhenRaining() {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
            Console.SetOut(sw);

            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("rainy");

            sw.Flush();

            Assert.Equal("It is rainy\r\n", Encoding.ASCII.GetString(ms.ToArray()));
        }

        [Fact]
        public void testAlertsViaEmailWhenSunny() {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
            Console.SetOut(sw);

            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("sunny");

            sw.Flush();

            Assert.Equal("It is sunny\r\n", Encoding.ASCII.GetString(ms.ToArray()));
        }

    }
}