using Xunit;

namespace SOLID.Net.InterfaceSegregation_Good
{
    public class PenguinTest
    {
        [Fact]
        public void testItCanSwim() {
            Penguin penguin = new Penguin(5);
            penguin.swim();
            Assert.Equal("in the water", penguin.currentLocation);
        }

        [Fact]
        public void testItLosesFeathersQuickly() {
            Penguin penguin = new Penguin(5);
            penguin.molt();
            Assert.Equal(1, penguin.numberOfFeathers);
        }

    }
}