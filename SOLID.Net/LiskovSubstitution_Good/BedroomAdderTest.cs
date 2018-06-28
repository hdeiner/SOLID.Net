using Xunit;

namespace SOLID.Net.LiskovSubstitution_Good
{
    public class BedroomAdderTest
    {
        [Fact]
        public void testAddsBedroomToPenthouse() {
            PenthouseSuite penthouse = new PenthouseSuite();
            BedroomAdder adder = new BedroomAdder();
            adder.addBedroom(penthouse);

            Assert.Equal(5, penthouse.numberOfBedrooms);
        }
     
    }
}