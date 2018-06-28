using Xunit;

namespace SOLID.Net.LiskovSubstitution_Bad
{
    public class UnitUpgraderTest
    {
        [Fact]
        public void testUpgraderIncreasesSquareFootageOfPenthouse() {
            PenthouseSuite penthouse = new PenthouseSuite();
            penthouse.setSquareFootage(1500);
            UnitUpgrader upgrader = new UnitUpgrader();
            upgrader.upgrade(penthouse);

            Assert.Equal(1540, penthouse.squareFootage);
        }

        [Fact]
        public void testUpgraderAddsBedroomToApartment() {
            PenthouseSuite penthouse = new PenthouseSuite();
            UnitUpgrader upgrader = new UnitUpgrader();
            upgrader.upgrade(penthouse);

            Assert.Equal(5, penthouse.numberOfBedrooms);
        }

        [Fact]
        public void testUpgraderIncreasesSquareFootageOfStudio() {
            Studio studio = new Studio();
            studio.setSquareFootage(550);
            UnitUpgrader upgrader = new UnitUpgrader();
            upgrader.upgrade(studio);

            Assert.Equal(590, studio.squareFootage);
        }

        [Fact]
        public void testUpgraderDoesntAddBedroomToStudios() {
            Studio studio = new Studio();
            UnitUpgrader upgrader = new UnitUpgrader();
            upgrader.upgrade(studio);

            Assert.Equal(0, studio.numberOfBedrooms);
        }

    }
}