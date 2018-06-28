using System;

namespace SOLID.Net.InterfaceSegregation_Good
{
    public class Eagle : FeatheredCreature, FlyingCreature
    {
        public String currentLocation;
        public int numberOfFeathers;

        public Eagle(int initialNumberOfFeathers) {
            this.numberOfFeathers = initialNumberOfFeathers;
        }

        public void fly() {
            this.currentLocation = "in the air";
        }

        public void molt() {
            this.numberOfFeathers -= 1;
        }

    }
}