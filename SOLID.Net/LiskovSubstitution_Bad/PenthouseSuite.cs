namespace SOLID.Net.LiskovSubstitution_Bad
{
    public class PenthouseSuite : Apartment
    {
        public PenthouseSuite() {
            this.numberOfBedrooms = 4;
        }

        override public void  setSquareFootage(int sqft) {
            this.squareFootage = sqft;
        }

    }
}