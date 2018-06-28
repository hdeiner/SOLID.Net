using Xunit;

namespace SOLID.Net.DependencyInversion_Bad
{
    public class EmailerTest
    {
        [Fact]
        public void testGeneratesAlertString() {
            Emailer emailer = new Emailer();
            Assert.Equal("It is sunny", emailer.generateWeatherAlert("sunny"));
        }

    }
}