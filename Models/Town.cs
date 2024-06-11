namespace DemographicsGenerator.Models
{
    public class Town
    {
        public string? Name { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        public static Town GetRandomTown()
        {
            Town town = Helpers.Utility.GetResource<Town>(Constants.Resources.TownFilePath);
            return town;
        }
    }
}