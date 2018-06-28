namespace SOLID.Net.LiskovSubstitution_Bad
{
    public class Studio : Apartment
    {
        public Studio() {
            this.numberOfBedrooms = 0;
        }

        override public void setSquareFootage(int sqft) {
            this.squareFootage = sqft;
        }

    }
}