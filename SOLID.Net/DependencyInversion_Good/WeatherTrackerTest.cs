using System;
using System.Text;
using SOLID.Net.OpenClosed_Good;
using Xunit;

namespace SOLID.Net.DependencyInversion_Good
{
    class MockNotifier : Notifier 
    {
        public void alertWeatherConditions(String weatherDescription) 
        {
            Console.WriteLine("foo");
        }
    }

    public class WeatherTrackerTest
    {
        [Fact]
        public void testSetsCurrentWeatherConditions() {
            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("cloudy");

            Assert.Equal("cloudy", tracker.currentConditions);
        }

        [Fact]
        public void testNotifiesWhenWeatherChanges() {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
            Console.SetOut(sw);

            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("cloudy");
            MockNotifier mockNotifier = new MockNotifier();
            tracker.notify(mockNotifier);

            sw.Flush();

            Assert.Equal("foo\r\n", Encoding.ASCII.GetString(ms.ToArray()));
        }

    }
}