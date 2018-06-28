using Xunit;

namespace SOLID.Net.LiskovSubstitution_Good
{
    public class StudioTest
    {
        [Fact]
        public void testInitializedWithZeroBedrooms() {
            Studio studio = new Studio();
            Assert.Equal(0, studio.numberOfRooms);
        }

        [Fact]
        public void testSetsSquareFootage() {
            Studio studio = new Studio();
            studio.setSquareFootage(550);

            Assert.Equal(550, studio.squareFootage);
        }

    }
}