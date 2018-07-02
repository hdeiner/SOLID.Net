using System;
using System.Text;
using Xunit;

namespace SOLID.Net.DependencyInversion_Good
{
    public class EmailClientTest
    {
        [Fact]
        public void testAlertsWhenSunny() {
            EmailClient gmail = new EmailClient();
            gmail.alertWeatherConditions("sunny");
            Assert.Equal("It is sunny", gmail.getConsoleOutput());
        }

    }
}