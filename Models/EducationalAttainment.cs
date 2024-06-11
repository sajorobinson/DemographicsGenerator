namespace DemographicsGenerator.Models
{
    public class EducationalAttainment
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public static EducationalAttainment GetRandomEducationalAttainment()
        {
            EducationalAttainment educationalAttainment = Helpers.Utility.GetResource<EducationalAttainment>(Constants.Resources.EducationalAttainmentFilePath);
            return educationalAttainment;
        }
    }
}