namespace SOLID.Net.LiskovSubstitution_Bad
{
    public abstract class Apartment
    {
        public int squareFootage;
        public int numberOfBedrooms;

        abstract public void setSquareFootage(int sqft);
    }
}