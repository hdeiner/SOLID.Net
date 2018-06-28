namespace SOLID.Net.LiskovSubstitution_Good
{
    public class BedroomAdder
    {
        public void addBedroom(PenthouseSuite penthouse) {
            penthouse.numberOfBedrooms += 1;
        }
 
    }
}