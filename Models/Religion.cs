namespace DemographicsGenerator.Models
{
    public class Religion
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public static Religion GetRandomReligion()
        {
            Religion religion = Helpers.Utility.GetResource<Religion>(Constants.Resources.ReligionFilePath);
            return religion;
        }
    }
}