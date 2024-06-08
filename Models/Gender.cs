namespace Models
{
    public class Gender
    {
        public string? Name { get; set; }
        public static Gender Get()
        {
            Gender gender = Helpers.Utility.GetResource<Gender>(Helpers.Constants.Resources.GenderFilePath);
            return gender;
        }
    }
}