using System;
using System.IO;
using Xunit;

namespace SOLID.Net.DependencyInversion_Good
{
    public class MobileDeviceTest
    {
        [Fact]
        public void testAlertsWhenRainy() {
            StreamWriter sw = new StreamWriter(new FileStream("tmp.txt", FileMode.Create));
            Console.SetOut(sw);

            MobileDevice iPhone = new MobileDevice();
            iPhone.alertWeatherConditions("rainy");

            sw.Flush();
            sw.Close();

            Assert.Equal("It is rainy\n", File.ReadAllText("tmp.txt"));
        }

    }
}