using System;
using System.IO;
using Xunit;

namespace SOLID.Net.DependencyInversion_Good
{
    public class EmailClientTest
    {
        [Fact]
        public void testAlertsWhenSunny() {
            StreamWriter sw = new StreamWriter(new FileStream("tmp.txt", FileMode.Create));
            Console.SetOut(sw);

            EmailClient gmail = new EmailClient();
            gmail.alertWeatherConditions("sunny");

            sw.Flush();
            sw.Close();

            Assert.Equal("It is sunny\n", File.ReadAllText("tmp.txt"));
        }

    }
}