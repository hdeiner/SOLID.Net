using Xunit;

namespace SOLID.Net.OpenClosed_Bad
{
    public class GreeterTest
    {
        [Fact]
        public void testSaysHello() {
            Greeter greeter = new Greeter();
            Assert.Equal("Hello.", greeter.greet());
        }

        [Fact]
        public void testSaysHelloFormally() {
            Greeter greeter = new Greeter();
            greeter.setFormality("formal");
            Assert.Equal("Good evening, sir.", greeter.greet());
        }

        [Fact]
        public void testSaysHelloCasually() {
            Greeter greeter = new Greeter();
            greeter.setFormality("casual");
            Assert.Equal("Sup bro?", greeter.greet());
        }

        [Fact]
        public void testSaysHelloIntimately() {
            Greeter greeter = new Greeter();
            greeter.setFormality("intimate");
            Assert.Equal("Hello Darling!", greeter.greet());
        }
        
    }
}