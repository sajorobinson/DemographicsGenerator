namespace DemographicsGenerator.Models
{
    public class Ethnicity
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static Ethnicity GetRandomEthnicity()
        {
            List<Ethnicity> ethnicityList = Helpers.Utility.GetRandomResourceList<Ethnicity>(Constants.Resources.EthnicityFilePath);
            Ethnicity ethnicity = Helpers.Utility.GetRandomResource<Ethnicity>(ethnicityList);
            return ethnicity;
        }
    }
}
