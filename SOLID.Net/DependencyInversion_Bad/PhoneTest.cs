using Xunit;

namespace SOLID.Net.DependencyInversion_Bad
{
    public class PhoneTest
    {
        [Fact]
        public void testGeneratesAlertString() {
            Phone phone = new Phone();
            Assert.Equal("It is rainy", phone.generateWeatherAlert("rainy"));
        }
      
    }
}