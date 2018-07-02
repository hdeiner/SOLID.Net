using System;
using System.Text;
using Xunit;

namespace SOLID.Net.DependencyInversion_Good
{
    public class EmailClientTest
    {
        [Fact]
        public void testAlertsWhenSunny() {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ms);
            Console.SetOut(sw);

            EmailClient gmail = new EmailClient();
            gmail.alertWeatherConditions("sunny");

            sw.Flush();

            Assert.Equal("It is sunny\r\n", Encoding.ASCII.GetString(ms.ToArray()));
        }

    }
}