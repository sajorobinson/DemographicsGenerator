namespace Models
{
    public class Gender
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public string GetRandomName()
        {
            Gender gender = Helpers.Utility.GetResource<Gender>(Constants.Resources.GenderFilePath);
            return gender.Name;
        }
    }
}