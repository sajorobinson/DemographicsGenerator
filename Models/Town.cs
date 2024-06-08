namespace Models
{
    public class Town
    {
        public string? Name { get; set; }
        public string? State { get; set; }
        public List<Person>? Population { get; set; }
        public static Town Get()
        {
            Town town = Helpers.Utility.GetResource<Town>(Constants.Resources.TownFilePath);
            return town;
        }
    }
}