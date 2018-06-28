using System;

namespace SOLID.Net.OpenClosed_Good
{
    public class Greeter
    {
        private Personality personality;

        public Greeter(Personality personality) {
            this.personality = personality;
        }

        public String greet() {
            return this.personality.greet();
        }

    }
}