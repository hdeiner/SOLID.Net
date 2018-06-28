using Xunit;

namespace SOLID.Net.OpenClosed_Good
{
    public class FormalPersonalityTest
    {
        [Fact]
        public void testGreetsSomeoneFormally() {
            FormalPersonality fp = new FormalPersonality();
            Assert.Equal("Good evening, sir.", fp.greet());
        }
    }
}