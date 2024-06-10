namespace Models
{
    public class Occupation
    {
        public string Name { get; set; } = Constants.Models.DefaultName;
        public string GetRandomName()
        {
            Occupation occupation = Helpers.Utility.GetResource<Occupation>(Constants.Resources.OccupationFilePath);
            return occupation.Name;
        }
    }
}