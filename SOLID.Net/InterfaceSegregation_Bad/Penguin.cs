using System;

namespace SOLID.Net.InterfaceSegregation_Bad
{
    public class Penguin : Bird
    {
        public String currentLocation;
        public int numberOfFeathers;

        public Penguin(int initialFeatherCount) {
            this.numberOfFeathers = initialFeatherCount;
        }

        public void molt() {
            this.numberOfFeathers -= 1;
        }

        public void fly() {
            throw new NotSupportedException("penquins can't fly");
        }

        public void swim() {
            this.currentLocation = "in the water";
        }
  
    }
}