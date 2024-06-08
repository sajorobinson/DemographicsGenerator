namespace Models
{
    public class Gender
    {
        public string? Name { get; set; }
        public static Gender Get()
        {
            Gender gender = Helpers.Utility.GetResource<Gender>(Constants.Resources.GenderFilePath);
            return gender;
        }
    }
}