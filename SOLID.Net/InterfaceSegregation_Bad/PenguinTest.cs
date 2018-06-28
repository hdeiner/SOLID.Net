using System;
using System.Security.Authentication;
using Xunit;

namespace SOLID.Net.InterfaceSegregation_Bad
{
    public class PenguinTest
    {
        [Fact]
        public void testItLosesFeathers() {
            Penguin penguin = new Penguin(5);
            penguin.molt();
            Assert.Equal(4, penguin.numberOfFeathers);
        }

        [Fact]
        public void testItCantActuallyFly() {
            Penguin penguin = new Penguin(5);
            Exception ex = Assert.Throws<NotSupportedException>(() => penguin.fly());
            Assert.Equal("penquins can't fly", ex.Message);
        }

        [Fact]
        public void testItCanSwim() {
            Penguin penguin = new Penguin(5);
            penguin.swim();
            Assert.Equal("in the water", penguin.currentLocation);
        }
 
    }
}