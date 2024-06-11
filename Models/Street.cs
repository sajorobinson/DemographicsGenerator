namespace DemographicsGenerator.Models;

public class Street
{
    public string Name { get; set; } = "123 Fake Street";

    public static Street GetRandomStreet()
    {
        Street street = Helpers.Utility.GetResource<Street>(Constants.Resources.StreetFilePath);
        return street;
    }
}