namespace DemographicsGenerator.Models
{
    public class Ethnicity
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public static Ethnicity GetRandomEthnicity()
        {
            Ethnicity ethnicity = Helpers.Utility.GetResource<Ethnicity>(Constants.Resources.EthnicityFilePath);
            return ethnicity;
        }
    }
}