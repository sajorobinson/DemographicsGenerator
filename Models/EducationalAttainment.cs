namespace Models
{
    public class EducationalAttainment
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public string GetRandomName()
        {
            EducationalAttainment educationalAttainment = Helpers.Utility.GetResource<EducationalAttainment>(Constants.Resources.EducationalAttainmentFilePath);
            return educationalAttainment.Name;
        }
    }
}