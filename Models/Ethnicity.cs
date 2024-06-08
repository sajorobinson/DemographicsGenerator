namespace Models
{
    public class Ethnicity
    {
        public string? Name { get; set; }
        public static Ethnicity Get()
        {
            Ethnicity ethnicity = Helpers.Utility.GetResource<Ethnicity>(Constants.Resources.EthnicityFilePath);
            return ethnicity;
        }
    }
}