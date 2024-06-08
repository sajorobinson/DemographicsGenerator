namespace Models
{
    public class EducationalAttainment
    {
        string? Name { get; set; }
        public static EducationalAttainment Get()
        {
            EducationalAttainment educationalAttainment = Helpers.Utility.GetResource<EducationalAttainment>(Constants.Resources.EducationalAttainmentFilePath);
            return educationalAttainment;
        }
    }
}