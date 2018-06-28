using System;
using Xunit;

namespace SOLID.Net.OpenClosed_Good
{
    class MockPersonality : Personality 
    {
        public String greet() 
        {
            return "foo";
        }
    }
    public class GreeterTest
    {
        [Fact]
        public void testGreetsSomeone() {
            MockPersonality mockPersonality = new MockPersonality();
            Greeter greeter = new Greeter(mockPersonality);

            Assert.Equal("foo", greeter.greet());
        }

    }
}