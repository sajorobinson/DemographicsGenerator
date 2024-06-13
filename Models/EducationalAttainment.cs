namespace DemographicsGenerator.Models
{
    public class EducationalAttainment
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;
        public int Level { get; set; }

        public static EducationalAttainment GetRandomEducationalAttainment()
        {
            List<EducationalAttainment> educationalAttainmentList = Helpers.Utility.GetRandomResourceList<EducationalAttainment>(Constants.Resources.EducationalAttainmentFilePath);
            EducationalAttainment educationalAttainment = Helpers.Utility.GetRandomResource<EducationalAttainment>(educationalAttainmentList);
            return educationalAttainment;
        }
    }
}
