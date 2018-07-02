using System;
using Xunit;

namespace SOLID.Net.DependencyInversion_Good
{
    public class MobileDeviceTest
    {
        [Fact]
        public void testAlertsWhenRainy() {
            MobileDevice iPhone = new MobileDevice();
            iPhone.alertWeatherConditions("rainy");
            Assert.Equal("It is rainy", iPhone.getConsoleOutput());
        }

    }
}