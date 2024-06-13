namespace DemographicsGenerator.Models
{
    public class Town
    {
        public string? Name { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        public static Town GetRandomTown()
        {
            List<Town> townList = Helpers.Utility.GetRandomResourceList<Town>(Constants.Resources.TownFilePath);
            Town town = Helpers.Utility.GetRandomResource<Town>(townList);
            return town;
        }
    }
}
