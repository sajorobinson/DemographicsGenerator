namespace DemographicsGenerator.Models
{
    public class Religion
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static Religion GetRandomReligion()
        {
            List<Religion> religionList = Helpers.Utility.GetRandomResourceList<Religion>(Constants.Resources.ReligionFilePath);
            Religion religion = Helpers.Utility.GetRandomResource<Religion>(religionList);
            return religion;
        }
    }
}
