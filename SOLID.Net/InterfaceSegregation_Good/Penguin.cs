using System;

namespace SOLID.Net.InterfaceSegregation_Good
{
    public class Penguin : SwimmingCreature, FeatheredCreature
    {
        public String currentLocation;
        public int numberOfFeathers;

        public Penguin(int initialFeatherCount) {
            this.numberOfFeathers = initialFeatherCount;
        }

        public void swim() {
            this.currentLocation = "in the water";
        }

        public void molt() {
            this.numberOfFeathers -= 4;
        }

    }
}