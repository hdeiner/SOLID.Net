using Xunit;

namespace SOLID.Net.OpenClosed_Good
{
    public class IntimatePersonalityTest
    {
        [Fact]
        public void testGreetsSomeoneIntimately() {
            IntimatePersonality ip = new IntimatePersonality();
            Assert.Equal("Hello Darling!", ip.greet());
        }
    }
}