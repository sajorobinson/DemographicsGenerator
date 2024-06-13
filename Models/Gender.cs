namespace DemographicsGenerator.Models
{
    public class Gender
    {
        public string Name { get; set; } = Constants.Models.DefaultResponse;

        public static Gender GetRandomGender()
        {
            List<Gender> genderList = Helpers.Utility.GetRandomResourceList<Gender>(Constants.Resources.GenderFilePath);
            Gender gender = Helpers.Utility.GetRandomResource<Gender>(genderList);
            return gender;
        }
    }
}
