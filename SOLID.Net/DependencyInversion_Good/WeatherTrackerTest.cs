using System;
using System.Collections.Generic;
using System.Text;
using SOLID.Net.DependencyInversion_Good;
using SOLID.Net.OpenClosed_Good;
using Xunit;

namespace SOLID.Net.DependencyInversion_Good
{
    class MockNotifier : Notifier 
    {
        private List<String> consoleOutput;

        public MockNotifier() {
            consoleOutput = new List<string>();
        }
        
        public void alertWeatherConditions(String weatherDescription) {
            consoleOutput.Add("foo");
        }

        public String getConsoleOutput() {
            return String.Join("\n", consoleOutput);
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
            WeatherTracker tracker = new WeatherTracker();
            tracker.setCurrentConditions("cloudy");
            MockNotifier mockNotifier = new MockNotifier();
            tracker.notify(mockNotifier);
            Assert.Equal("foo", mockNotifier.getConsoleOutput());
        }

    }
}