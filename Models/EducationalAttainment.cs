namespace DemographicsGenerator.Models
{
    public class EducationalAttainment
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static EducationalAttainment GetRandomEducationalAttainment()
        {
            EducationalAttainment educationalAttainment =
                Helpers.Utility.GetResource<EducationalAttainment>(Constants.Resources.EducationalAttainmentFilePath);
            return educationalAttainment;
        }
    }
}