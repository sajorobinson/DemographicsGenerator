namespace DemographicsGenerator.Models
{
    public class Gender
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public static Gender GetRandomGender()
        {
            Gender gender = Helpers.Utility.GetResource<Gender>(Constants.Resources.GenderFilePath);
            return gender;
        }
    }
}