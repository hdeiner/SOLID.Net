using Xunit;

namespace SOLID.Net.LiskovSubstitution_Bad
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
            penthouse.setSquareFootage(1500);
            Assert.Equal(1500, penthouse.squareFootage);
        }
        
    }
}