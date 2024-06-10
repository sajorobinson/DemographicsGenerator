namespace Models
{
    public class Ethnicity
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public string GetRandomName()
        {
            Ethnicity ethnicity = Helpers.Utility.GetResource<Ethnicity>(Constants.Resources.EthnicityFilePath);
            return ethnicity.Name;
        }
    }
}