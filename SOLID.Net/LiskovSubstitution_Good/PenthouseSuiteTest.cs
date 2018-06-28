using Xunit;

namespace SOLID.Net.LiskovSubstitution_Good
{
    public class PenthouseSuiteTest
    {
        [Fact]
        public void testInitializedWithFourBedrooms() {
            PenthouseSuite penthouse = new PenthouseSuite();
            Assert.Equal(4, penthouse.numberOfBedrooms);
        }

        [Fact]
        public void testSetsSquareFootage() {
            PenthouseSuite penthouse = new PenthouseSuite();
            penthouse.setSquareFootage(1600);

            Assert.Equal(1600, penthouse.squareFootage);
        }

    }
}