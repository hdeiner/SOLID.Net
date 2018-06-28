using Xunit;

namespace SOLID.Net.OpenClosed_Good
{
    public class CasualPersonalityTest
    {
        [Fact]
        public void testGreetsSomeoneCasually() {
            CasualPersonality cp = new CasualPersonality();
            Assert.Equal("Sup bro?", cp.greet());
        }

    }
}