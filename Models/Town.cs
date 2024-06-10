namespace Models
{
    public class Town
    {
        public string? Name { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public List<Person>? Population { get; set; }
        public string? GetRandomName()
        {
            Town town = Helpers.Utility.GetResource<Town>(Constants.Resources.TownFilePath);
            return town.Name;
        }
    }
}