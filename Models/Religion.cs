namespace Models
{
    public class Religion
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public string? GetRandomName()
        {
            Religion religion = Helpers.Utility.GetResource<Religion>(Constants.Resources.ReligionFilePath);
            return religion.Name;
        }
    }
}