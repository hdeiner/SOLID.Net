using Xunit;

namespace SOLID.Net.LiskovSubstitution_Bad
{
    public class StudioTest
    {
        [Fact]
        public void testInitializedWithZeroBedrooms() {
            Studio studio = new Studio();
            Assert.Equal(0, studio.numberOfBedrooms);
        }

        [Fact]
        public void testSetSquareFootage() {
            Studio studio = new Studio();
            studio.setSquareFootage(600);
            Assert.Equal(600, studio.squareFootage);
        }

    }
}