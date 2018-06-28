using Xunit;

namespace SOLID.Net.InterfaceSegregation_Bad
{
    public class EagleTest
    {
        [Fact]
        public void testItFliesInTheAir() {
            Eagle eagle = new Eagle(5);
            eagle.fly();
            Assert.Equal("in the air", eagle.currentLocation);
        }

        [Fact]
        public void testItLosesFeathers() {
            Eagle eagle = new Eagle(5);
            eagle.molt();
            Assert.Equal(4, eagle.numberOfFeathers);
        }

    }
}