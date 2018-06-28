using System;
using System.IO;
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
            StreamWriter sw = new StreamWriter(new FileStream("tmp.txt", FileMode.Create));
            Console.SetOut(sw);

            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("cloudy");
            MockNotifier mockNotifier = new MockNotifier();
            tracker.notify(mockNotifier);

            sw.Flush();
            sw.Close();

            Assert.Equal("foo\n", File.ReadAllText("tmp.txt"));
        }

    }
}