using System;
using System.Text;
using Xunit;

namespace SOLID.Net.DependencyInversion_Good
{
    public class MobileDeviceTest
    {
        [Fact]
        public void testAlertsWhenRainy() {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
            Console.SetOut(sw);

            MobileDevice iPhone = new MobileDevice();
            iPhone.alertWeatherConditions("rainy");

            sw.Flush();

            Assert.Equal("It is rainy\n", Encoding.ASCII.GetString(ms.ToArray()).Replace("\r",""));
        }

    }
}