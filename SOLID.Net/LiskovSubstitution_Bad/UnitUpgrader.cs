namespace SOLID.Net.LiskovSubstitution_Bad
{
    public class UnitUpgrader
    {
        public void upgrade(Apartment apartment) {
            apartment.squareFootage += 40;

            if (apartment.GetType().Name != "Studio")
                apartment.numberOfBedrooms += 1;
        }

    }
}