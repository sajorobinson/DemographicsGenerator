namespace DemographicsGenerator.Models
{
    public class Street
    {
        public string Name { get; set; } = "123 Fake Street";

        public static Street GetRandomStreet()
        {
            List<Street> streetList = Helpers.Utility.GetRandomResourceList<Street>(Constants.Resources.StreetFilePath);
            Street street = Helpers.Utility.GetRandomResource<Street>(streetList);
            return street;
        }
    }
}
